using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class BleedModifier : BurnModifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			float Interval();

			float DamageScale();

			DamageType ShowDamageType();
		}

		private class BurnInfoAdapter : BurnInfo
		{
			private Info info;

			public BurnInfoAdapter(Info info)
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

			public float Interval()
			{
				return 0f;
			}

			public float DamageScale()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private Info info;

		private ModifierVfxManager vfxManager;

		public BleedModifier(Info info, Entity caster, Entity target)
			: base(null, null, null)
		{
		}

		public override string Name()
		{
			return null;
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}

		public override void Update(float dt)
		{
		}

		public override void OnBeReplaced(Character character)
		{
		}

		public override void OnAttach(Character character)
		{
		}

		public override void OnDetach(Character character)
		{
		}

		public override object[] Cookies()
		{
			return null;
		}

		protected override DamageType ShowDamageType()
		{
			return default(DamageType);
		}
	}
}
