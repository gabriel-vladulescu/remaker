using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Core.Skills
{
	public class CooldownBuff : Buff
	{
		private float bonus;

		private float rawBonus;

		private bool playVfx;

		private CooldownModifier.Mode mode;

		private string source;

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

		public bool PlayVfx => false;

		public CooldownModifier.Mode Mode => default(CooldownModifier.Mode);

		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CooldownBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, float rawBonus, bool playVfx, CooldownModifier.Mode mode, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
