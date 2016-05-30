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
        public BuidlingComponent buidling { get { return (BuidlingComponent)GetComponent(ComponentIds.Buidling); } }

        public bool hasBuidling { get { return HasComponent(ComponentIds.Buidling); } }

        public Entity AddBuidling(BuildingType newType) {
            var component = CreateComponent<BuidlingComponent>(ComponentIds.Buidling);
            component.Type = newType;
            return AddComponent(ComponentIds.Buidling, component);
        }

        public Entity ReplaceBuidling(BuildingType newType) {
            var component = CreateComponent<BuidlingComponent>(ComponentIds.Buidling);
            component.Type = newType;
            ReplaceComponent(ComponentIds.Buidling, component);
            return this;
        }

        public Entity RemoveBuidling() {
            return RemoveComponent(ComponentIds.Buidling);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherBuidling;

        public static IMatcher Buidling {
            get {
                if (_matcherBuidling == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Buidling);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherBuidling = matcher;
                }

                return _matcherBuidling;
            }
        }
    }
}
