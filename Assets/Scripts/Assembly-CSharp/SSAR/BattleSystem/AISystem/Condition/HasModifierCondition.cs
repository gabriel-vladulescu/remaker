using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class HasModifierCondition : AbsCondition
	{
		public ModifierType modifierType;

		public bool isSelf;

		public bool reverse;

		public HasModifierCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		public override void OnChangeToAwake()
		{
		}

		public override void OnExcute()
		{
		}

		public override void OnExcuteAction(float deltaTime)
		{
		}

		public override void OnExcuteOutOfAction(float deltaTime)
		{
		}

		public override void OnExitAction()
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}

		public bool HasModifier()
		{
			return false;
		}
	}
}
