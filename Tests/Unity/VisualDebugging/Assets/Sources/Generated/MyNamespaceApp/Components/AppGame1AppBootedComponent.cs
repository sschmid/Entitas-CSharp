//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public partial class AppEntity {

        static readonly Game1.AppBooted game1AppBootedComponent = new Game1.AppBooted();

        public bool isGame1AppBooted {
            get { return HasComponent(My.Namespace.AppComponentsLookup.Game1AppBooted); }
            set {
                if (value != isGame1AppBooted) {
                    var index = My.Namespace.AppComponentsLookup.Game1AppBooted;
                    if (value) {
                        var componentPool = GetComponentPool(index);
                        var component = componentPool.Count > 0
                                ? componentPool.Pop()
                                : game1AppBootedComponent;

                        AddComponent(index, component);
                    } else {
                        RemoveComponent(index);
                    }
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public partial class AppEntity : Game1.IGame1AppBootedEntity { }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public sealed partial class AppMatcher {

        static Entitas.IMatcher<AppEntity> _matcherGame1AppBooted;

        public static Entitas.IMatcher<AppEntity> Game1AppBooted {
            get {
                if (_matcherGame1AppBooted == null) {
                    var matcher = (Entitas.Matcher<AppEntity>)Entitas.Matcher<AppEntity>.AllOf(My.Namespace.AppComponentsLookup.Game1AppBooted);
                    matcher.componentNames = My.Namespace.AppComponentsLookup.componentNames;
                    _matcherGame1AppBooted = matcher;
                }

                return _matcherGame1AppBooted;
            }
        }
    }
}
