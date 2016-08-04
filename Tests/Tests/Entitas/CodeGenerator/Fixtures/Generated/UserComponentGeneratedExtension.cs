//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public UserComponent user { get { return (UserComponent)GetComponent(ComponentIds.User); } }

        public bool hasUser { get { return HasComponent(ComponentIds.User); } }

        public Entity AddUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var component = CreateComponent<UserComponent>(ComponentIds.User);
            component.timestamp = newTimestamp;
            component.isLoggedIn = newIsLoggedIn;
            return (Entity)AddComponent(ComponentIds.User, component);
        }

        public Entity ReplaceUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var component = CreateComponent<UserComponent>(ComponentIds.User);
            component.timestamp = newTimestamp;
            component.isLoggedIn = newIsLoggedIn;
            ReplaceComponent(ComponentIds.User, component);
            return this;
        }

        public Entity RemoveUser() {
            return (Entity)RemoveComponent(ComponentIds.User);
        }
    }

    public partial class Pool {
        public Entity userEntity { get { return GetGroup(Matcher.User).GetSingleEntity(); } }

        public UserComponent user { get { return userEntity.user; } }

        public bool hasUser { get { return userEntity != null; } }

        public Entity SetUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
            if (hasUser) {
                throw new EntitasException("Could not set user!\n" + this + " already has an entity with UserComponent!",
                    "You should check if the pool already has a userEntity before setting it or use pool.ReplaceUser().");
            }
            var entity = CreateEntity();
            entity.AddUser(newTimestamp, newIsLoggedIn);
            return entity;
        }

        public Entity ReplaceUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
            var entity = userEntity;
            if (entity == null) {
                entity = SetUser(newTimestamp, newIsLoggedIn);
            } else {
                entity.ReplaceUser(newTimestamp, newIsLoggedIn);
            }

            return entity;
        }

        public void RemoveUser() {
            DestroyEntity(userEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherUser;

        public static IMatcher User {
            get {
                if (_matcherUser == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.User);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherUser = matcher;
                }

                return _matcherUser;
            }
        }
    }
}
