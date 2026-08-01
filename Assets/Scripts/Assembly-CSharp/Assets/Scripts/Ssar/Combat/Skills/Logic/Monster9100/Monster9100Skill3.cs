using Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75011;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster9100
{
	public class Monster9100Skill3 : Monster75011Skill2
	{
		public class SkillInfo : Info
		{
			public int columnCount;

			public float rangeEachColumnX;

			public float distanceBetweenColumnX;
		}

		private SkillInfo skillInfo;

		private float lastOffsetX;

		private float nextOffsetX;

		private float centerOffsetX;

		public Monster9100Skill3(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void Activate()
		{
		}
	}
}
