namespace Assets.Scripts.Core.Skills
{
	public class DarkArcaneBuff : Buff
	{
		private float skillDurationExtensionPerKill;

		public float SkillDurationExtensionPerKill => 0f;

		public DarkArcaneBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, float skillDurationExtensionPerKill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
