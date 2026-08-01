using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills
{
	public class PoisonBuff : Buff
	{
		public float movementSpeedBonus;

		public float damageInterval;

		public float damageScale;

		public bool playVfx;

		public string fxPath;

		public DamageType damageType;

		public float MovementSpeedBonus => 0f;

		public float DamageInterval => 0f;

		public float DamageScale => 0f;

		public bool PlayVfx => false;

		public string FxPath => null;

		public DamageType DamageType => default(DamageType);

		public PoisonBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, float movementSpeedBonus, float damageInterval, float damageScale, bool playVfx, string fxPath, DamageType damageType)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
