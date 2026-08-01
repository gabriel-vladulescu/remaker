using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

public class BlockInputPopupMediator : Mediator
{
	[Inject]
	public BlockInputPopup view { get; set; }

	[Inject]
	public HideBlockInputPopupSignal HideBlockInputPopupSignal { get; set; }

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
