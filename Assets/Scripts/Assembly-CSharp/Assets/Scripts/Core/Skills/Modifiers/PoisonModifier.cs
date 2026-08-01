using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class PoisonModifier : ColdBurnModifier
	{
		public new interface Info
		{
			float SuccessRate();

			float Duration();

			float MovementSpeedBonus();

			float DamageInterval();

			float DamageScale();

			bool ShouldPlayVfx();

			string FxPath();

			DamageType DamageType();
		}

		private class ColdBurnInfoAdapter : ColdBurnModifier.Info
		{
			private Info info;

			public ColdBurnInfoAdapter(Info info)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float MovementSpeedBonus()
			{
				return 0f;
			}

			public float BurnInterval()
			{
				return 0f;
			}

			public float BurnDamageScale()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private Info info;

		public PoisonModifier(Info info, Entity caster, Entity target)
			: base(null, null, null)
		{
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}

		protected override EffectPathIndex GetBurnVfx()
		{
			return default(EffectPathIndex);
		}

		protected override string GetEffectPath()
		{
			return null;
		}

		protected override DamageType GetDamageType()
		{
			return default(DamageType);
		}

		public new object[] Cookies()
		{
			return null;
		}
	}
}
