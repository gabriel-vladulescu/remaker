using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class BossHealthBarMediator : Mediator
	{
		[Inject]
		public BossHealthBarView view { get; set; }

		[Inject]
		public FinishSpawnMonsterSignal FinishSpawnMonsterSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
