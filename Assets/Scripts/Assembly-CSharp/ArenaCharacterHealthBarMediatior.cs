using Assets.Scripts.Ssar.Dungeon.Signal;
using Assets.Scripts.Ssar.Dungeon.View;
using strange.extensions.mediation.impl;

public class ArenaCharacterHealthBarMediatior : Mediator
{
	[Inject]
	public ArenaCharacterHealthBarView view { get; set; }

	[Inject]
	public ChangeToArcaneFormSignal ChangeToArcaneFormSignal { get; set; }

	[Inject]
	public BackToNormalFormSignal BackToNormalFormSignal { get; set; }

	[Inject]
	public UpdateArcaneFormRemainingDurationSignal UpdateArcaneFormRemainingDurationSignal { get; set; }

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
