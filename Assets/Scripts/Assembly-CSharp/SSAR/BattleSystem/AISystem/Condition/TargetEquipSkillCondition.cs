using Artemis;
using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class TargetEquipSkillCondition : AbsCondition
	{
		public bool reverse;

		public string skillId;

		public TargetEquipSkillCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
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

		private bool IsEquipSkill()
		{
			return false;
		}

		public bool IsEquipSkill(Entity target, string skillId)
		{
			return false;
		}
	}
}
