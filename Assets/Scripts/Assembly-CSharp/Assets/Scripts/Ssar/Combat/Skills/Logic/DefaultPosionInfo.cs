using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultPosionInfo : PoisonModifier.Info
	{
		private float successRate;

		private float duration;

		private float movementSpeedBonus;

		private float damageInterval;

		private float damageScale;

		private bool shouldPlayVfx;

		private string fxPath;

		private DamageType damageType;

		public DefaultPosionInfo(float successRate, float duration, float movementSpeedBonus, float damageInterval, float damageScale, bool shouldPlayVfx, string fxPath, DamageType damageType)
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

		public float DamageInterval()
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

		public string FxPath()
		{
			return null;
		}

		public DamageType DamageType()
		{
			return default(DamageType);
		}
	}
}
