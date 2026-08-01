using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.SkillSystem.View
{
	public class SkillManagerPopupMediator : Mediator
	{
		[Inject]
		public SkillManagerPopup view { get; set; }

		[Inject]
		public OnPurchaseSkillPointSuccessSignal OnPurchaseSkillPointSuccessSignal { get; set; }

		[Inject]
		public InvestSkillPointToRuneOfActiveSkillSignal InvestSkillPointToRuneOfActiveSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromRuneOfActiveSkillSigSnal DivestSkillPointFromRuneOfActiveSkillSignal { get; set; }

		[Inject]
		public InvestSkillPointToSignatureSkillSignal InvestSkillPointToSignatureSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromSignatureSkillSignal DivestSkillPointFromSignatureSkillSignal { get; set; }

		[Inject]
		public InvestSkillPointToPassiveSkillSignal InvestSkillPointToPassiveSkillSignal { get; set; }

		[Inject]
		public DivestSkillPointFromPassiveSkillSignal DivestSkillPointFromPassiveSkillSignal { get; set; }

		[Inject]
		public OnAddCharacterSkillPointSuccessSignal OnAddCharacterSkillPointSuccessSignal { get; set; }

		[Inject]
		public OnSwapSkillSignal OnSwapSkillSignal { get; set; }

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
