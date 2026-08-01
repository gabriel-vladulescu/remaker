using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.BattleSystem.AI
{
	public class OnAttachModifierTrigger : AbsTrigger
	{
		public float rate;

		public float pointDeduct;

		public int attachTimesRequireInTime;

		public float timeThreshold;

		private float t;

		private int count;

		public ModifierType modifier;

		public OnAttachModifierTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
