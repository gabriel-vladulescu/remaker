using System.Collections.Generic;

namespace SSAR.BattleSystem.System.Input.Model
{
	public class PrioritizedCharacterInput : CharacterInput
	{
		private Dictionary<string, int> priorityBySkillId;

		private string inUseSkillId;

		private bool isCastingPrioritized;

		public override bool CastSkill(int skillOrder, string skillId)
		{
			return false;
		}

		public override void OnSkillCastingRequestConsumed()
		{
		}

		public void AddPriority(string skillId, int priority)
		{
		}

		public override void ReleaseCastSkill(int skillOrder)
		{
		}

		public override bool IsInputSkill()
		{
			return false;
		}
	}
}
