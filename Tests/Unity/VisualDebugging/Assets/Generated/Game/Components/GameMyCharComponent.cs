//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyCharComponent myChar { get { return (MyCharComponent)GetComponent(GameComponentsLookup.MyChar); } }
    public bool hasMyChar { get { return HasComponent(GameComponentsLookup.MyChar); } }

    public void AddMyChar(char newMyChar) {
        var index = GameComponentsLookup.MyChar;
        var component = CreateComponent<MyCharComponent>(index);
        component.myChar = newMyChar;
        AddComponent(index, component);
    }

    public void ReplaceMyChar(char newMyChar) {
        var index = GameComponentsLookup.MyChar;
        var component = CreateComponent<MyCharComponent>(index);
        component.myChar = newMyChar;
        ReplaceComponent(index, component);
    }

    public void RemoveMyChar() {
        RemoveComponent(GameComponentsLookup.MyChar);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.Core.IMatcher<GameEntity> _matcherMyChar;

    public static Entitas.Core.IMatcher<GameEntity> MyChar {
        get {
            if(_matcherMyChar == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyChar);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyChar = matcher;
            }

            return _matcherMyChar;
        }
    }
}
