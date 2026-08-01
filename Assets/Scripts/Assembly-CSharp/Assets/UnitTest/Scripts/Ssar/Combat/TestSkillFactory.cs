using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.UnitTest.Scripts.Ssar.Combat
{
	internal class TestSkillFactory : SkillFactory
	{
		private ProjectileFactory projectileFactory;

		public TestSkillFactory(ProjectileFactory projectileFactory)
		{
		}

		public override Skill Create(string skillId)
		{
			return null;
		}

		public override EventFrame CreateDamageFrame(EventFrameConfig efc, float scaleTime, int waveOrder, float waveInterval)
		{
			return null;
		}
	}
}
