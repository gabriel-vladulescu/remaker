using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Assets.Scripts.Ssar.SceneLoader
{
	public class BattleScene : AbsSceneLogic
	{
		private IBattleModeLogic battleModeLogic;

		public IBattleModeLogic BattleModeLogic => null;

		public BattleScene(string sceneName, IBattleModeLogic battleModeLogic)
			: base(null)
		{
		}

		public override void OnExcute()
		{
		}
	}
}
