using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.Navigation.View;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DungeonEffectGoNextStageMediator : Mediator
	{
		[Inject]
		public DungeonEffectGoNextStageView View { get; set; }

		[Inject]
		public ShowDungeonEffectGoNextStageSignal ShowDungeonEffectGoNextStageSignal { get; set; }

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
