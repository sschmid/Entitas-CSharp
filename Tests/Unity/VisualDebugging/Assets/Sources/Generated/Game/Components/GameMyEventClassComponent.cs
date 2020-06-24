//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyEventClassComponent myEventClass { get { return (MyEventClassComponent)GetComponent(GameComponentsLookup.MyEventClass); } }
    public bool hasMyEventClass { get { return HasComponent(GameComponentsLookup.MyEventClass); } }

    public void AddMyEventClass(MyEventClass newValue) {
        var index = GameComponentsLookup.MyEventClass;
        var component = (MyEventClassComponent)CreateComponent(index, typeof(MyEventClassComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyEventClass(MyEventClass newValue) {
        var index = GameComponentsLookup.MyEventClass;
        var component = (MyEventClassComponent)CreateComponent(index, typeof(MyEventClassComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyEventClass() {
        RemoveComponent(GameComponentsLookup.MyEventClass);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMyEventClass;

    public static Entitas.IMatcher<GameEntity> MyEventClass {
        get {
            if (_matcherMyEventClass == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyEventClass);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyEventClass = matcher;
            }

            return _matcherMyEventClass;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventListenerComponentGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
[Entitas.CodeGeneration.Attributes.DontGenerate(false)]
public sealed class AnyMyEventClassListenerComponent : Entitas.IComponent {
    public System.Collections.Generic.List<IAnyMyEventClassListener> value;
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventListenertInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public interface IAnyMyEventClassListener {
    void OnAnyMyEventClass(GameEntity entity, MyEventClass value);
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnyMyEventClassEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly Entitas.IGroup<GameEntity> _listeners;
    readonly System.Collections.Generic.List<GameEntity> _entityBuffer;
    readonly System.Collections.Generic.List<IAnyMyEventClassListener> _listenerBuffer;

    public AnyMyEventClassEventSystem(Contexts contexts) : base(contexts.game) {
        _listeners = contexts.game.GetGroup(GameMatcher.AnyMyEventClassListener);
        _entityBuffer = new System.Collections.Generic.List<GameEntity>();
        _listenerBuffer = new System.Collections.Generic.List<IAnyMyEventClassListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.MyEventClass)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasMyEventClass;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.myEventClass;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.anyMyEventClassListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyMyEventClass(e, component.value);
                }
            }
        }
    }
}
