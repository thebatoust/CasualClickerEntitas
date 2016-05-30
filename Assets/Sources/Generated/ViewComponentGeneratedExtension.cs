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
        public ViewComponent view { get { return (ViewComponent)GetComponent(ComponentIds.View); } }

        public bool hasView { get { return HasComponent(ComponentIds.View); } }

        public Entity AddView(ViewController newView) {
            var component = CreateComponent<ViewComponent>(ComponentIds.View);
            component.View = newView;
            return AddComponent(ComponentIds.View, component);
        }

        public Entity ReplaceView(ViewController newView) {
            var component = CreateComponent<ViewComponent>(ComponentIds.View);
            component.View = newView;
            ReplaceComponent(ComponentIds.View, component);
            return this;
        }

        public Entity RemoveView() {
            return RemoveComponent(ComponentIds.View);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherView;

        public static IMatcher View {
            get {
                if (_matcherView == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.View);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherView = matcher;
                }

                return _matcherView;
            }
        }
    }
}