using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Core.Skills
{
	public class SkillFactory
	{
		public virtual Skill Create(string skillId)
		{
			return null;
		}

		public virtual EventFrame CreateDamageFrame(EventFrameConfig efc, float scaleTime, int waveOrder, float waveInterval)
		{
			return null;
		}

		public virtual EventFrame CreateSpawnMonsterFrame(EventFrameConfig efc, float frame)
		{
			return null;
		}
	}
}
