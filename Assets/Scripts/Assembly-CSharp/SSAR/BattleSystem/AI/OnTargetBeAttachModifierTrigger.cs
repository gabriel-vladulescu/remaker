using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.BattleSystem.AI
{
	public class OnTargetBeAttachModifierTrigger : AbsTrigger
	{
		public float rate;

		public float pointDeduct;

		public ModifierType modifier;

		public OnTargetBeAttachModifierTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}
	}
}
