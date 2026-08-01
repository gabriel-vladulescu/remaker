using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills
{
	public class BleedBuff : Buff
	{
		private float damageScale;

		private DamageType damageType;

		private float interval;

		public float DamageScale => 0f;

		public DamageType DamageType => default(DamageType);

		public float Interval => 0f;

		public BleedBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float damageScale, DamageType damageType, float interval, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
