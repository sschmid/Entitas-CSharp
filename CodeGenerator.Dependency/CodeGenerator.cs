using System;
using System.Collections.Generic;
using System.Linq;

namespace Entitas.CodeGeneration {
    public static class CodeGenerator {
        public const string COMPONENT_SUFFIX = "Component";
        public const string DEFAULT_COMPONENT_LOOKUP_TAG = "ComponentIds";

        public static CodeGenFile[] Generate(ICodeGeneratorDataProvider provider, ICodeGenerator[] codeGenerators, IPostProcessor[] postProcessors) {

            var generatedFiles = new List<CodeGenFile>();

            foreach (var generator in codeGenerators.OfType<IPoolCodeGenerator>()) {
                var files = generator.Generate(provider.poolNames);
                generatedFiles.AddRange(files);
            }

            foreach (var generator in codeGenerators.OfType<IComponentCodeGenerator>()) {
                var files = generator.Generate(provider.componentInfos);
                generatedFiles.AddRange(files);
            }

            foreach (var generator in codeGenerators.OfType<IBlueprintsCodeGenerator>()) {
                var files = generator.Generate(provider.blueprintNames);
                generatedFiles.AddRange(files);
            }

            var codeGenFiles = generatedFiles.ToArray();
            System.Console.WriteLine("codeGenFiles: " + codeGenFiles);
            foreach (var processor in postProcessors) {
                System.Console.WriteLine("Processor: " + processor);
                processor.Process(codeGenFiles);
            }

            return codeGenFiles;
        }
    }

    public static class CodeGeneratorExtensions {

        public static string[] ComponentLookupTags(this ComponentInfo componentInfo) {
            if (componentInfo.pools.Length == 0) {
                return new[] { CodeGenerator.DEFAULT_COMPONENT_LOOKUP_TAG };
            }

            return componentInfo.pools
                .Select(poolName => poolName + CodeGenerator.DEFAULT_COMPONENT_LOOKUP_TAG)
                .ToArray();
        }

        public static string UppercaseFirst(this string str) {
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string LowercaseFirst(this string str) {
            return char.ToLower(str[0]) + str.Substring(1);
        }

        public static string ToUnixLineEndings(this string str) {
            return str.Replace(Environment.NewLine, "\n");
        }
    }
}
