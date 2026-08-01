using SSAR.BattleSystem.Input;

namespace SSAR.BattleSystem.AI
{
	public class CastSkill11Action : CastSkill1Action
	{
		public CastSkill11Action(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override ActionType InPutSkill()
		{
			return default(ActionType);
		}

		protected override int SkillConfigOrder()
		{
			return 0;
		}
	}
}
