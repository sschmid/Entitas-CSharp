using System;

namespace Entitas.CodeGeneration {

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PoolAttribute : Attribute {
        public readonly string poolName;

        public PoolAttribute(string poolName) {
            this.poolName = poolName;
        }
    }
}