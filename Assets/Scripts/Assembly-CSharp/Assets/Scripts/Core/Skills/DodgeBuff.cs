namespace Assets.Scripts.Core.Skills
{
	public class DodgeBuff : Buff
	{
		private float bonus;

		private float rawBonus;

		public float Bonus
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RawBonus
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public DodgeBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, float rawBonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
