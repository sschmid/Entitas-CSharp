//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.PoolEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Entitas;

namespace Entitas {

    public interface IPoolCPoolEntity : IEntity {
        CComponent c { get; }
        bool hasC { get; }
        IPoolCPoolEntity AddC();
        IPoolCPoolEntity ReplaceC();
        IPoolCPoolEntity RemoveC();
        DComponent d { get; }
        bool hasD { get; }
        IPoolCPoolEntity AddD();
        IPoolCPoolEntity ReplaceD();
        IPoolCPoolEntity RemoveD();
        EComponent e { get; }
        bool hasE { get; }
        IPoolCPoolEntity AddE();
        IPoolCPoolEntity ReplaceE();
        IPoolCPoolEntity RemoveE();
        FComponent f { get; }
        bool hasF { get; }
        IPoolCPoolEntity AddF();
        IPoolCPoolEntity ReplaceF();
        IPoolCPoolEntity RemoveF();
    }
}
