using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Dungeon.Model;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Signal
{
	public class LoadTestAISceneSignal : Signal<TestAIInMode, ScenarioDifficulty, CharacterCode>
	{
	}
}
