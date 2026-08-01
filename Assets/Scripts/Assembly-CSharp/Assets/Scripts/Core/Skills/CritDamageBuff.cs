namespace Assets.Scripts.Core.Skills
{
	public class CritDamageBuff : Buff
	{
		private float damageMultiplier;

		public float DamageMultiplier => 0f;

		public CritDamageBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float damageMultiplier, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
