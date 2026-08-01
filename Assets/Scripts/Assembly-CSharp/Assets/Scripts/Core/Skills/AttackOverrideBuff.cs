namespace Assets.Scripts.Core.Skills
{
	public class AttackOverrideBuff : Buff
	{
		private float bonus;

		public float Bonus => 0f;

		public AttackOverrideBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
