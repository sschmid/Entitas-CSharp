using Entitas;
using Entitas.CodeGeneration;
using Entitas.Serialization;

public class SomeComponent : IComponent {
    public static ComponentInfo componentInfo { 
        get {
            return new ComponentInfo(
                typeof(SomeComponent).ToCompilableString(),
                new System.Collections.Generic.List<PublicMemberInfo>(),
                new string[0],
                false,
                "is",
                true,
                true
            );
        }
    }
}
