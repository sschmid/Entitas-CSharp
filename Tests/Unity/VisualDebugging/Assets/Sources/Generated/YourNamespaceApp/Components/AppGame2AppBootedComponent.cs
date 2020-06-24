//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public partial class AppContext {

        public AppEntity game2AppBootedEntity { get { return GetGroup(AppMatcher.Game2AppBooted).GetSingleEntity(); } }

        public bool isGame2AppBooted {
            get { return game2AppBootedEntity != null; }
            set {
                var entity = game2AppBootedEntity;
                if (value != (entity != null)) {
                    if (value) {
                        CreateEntity().isGame2AppBooted = true;
                    } else {
                        entity.Destroy();
                    }
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public partial class AppEntity {

        static readonly Game2.AppBooted game2AppBootedComponent = new Game2.AppBooted();

        public bool isGame2AppBooted {
            get { return HasComponent(YourNamespace.AppComponentsLookup.Game2AppBooted); }
            set {
                if (value != isGame2AppBooted) {
                    var index = YourNamespace.AppComponentsLookup.Game2AppBooted;
                    if (value) {
                        var componentPool = GetComponentPool(index);
                        var component = componentPool.Count > 0
                                ? componentPool.Pop()
                                : game2AppBootedComponent;

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
namespace YourNamespace {
    public partial class AppEntity : Game2.IGame2AppBootedEntity { }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public sealed partial class AppMatcher {

        static Entitas.IMatcher<AppEntity> _matcherGame2AppBooted;

        public static Entitas.IMatcher<AppEntity> Game2AppBooted {
            get {
                if (_matcherGame2AppBooted == null) {
                    var matcher = (Entitas.Matcher<AppEntity>)Entitas.Matcher<AppEntity>.AllOf(YourNamespace.AppComponentsLookup.Game2AppBooted);
                    matcher.componentNames = YourNamespace.AppComponentsLookup.componentNames;
                    _matcherGame2AppBooted = matcher;
                }

                return _matcherGame2AppBooted;
            }
        }
    }
}
