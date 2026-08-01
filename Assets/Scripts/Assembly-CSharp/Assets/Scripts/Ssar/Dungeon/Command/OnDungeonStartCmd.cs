using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnDungeonStartCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void SpawnFx()
		{
		}

		private EffectPathIndex GetEffect(int groupId)
		{
			return default(EffectPathIndex);
		}
	}
}
