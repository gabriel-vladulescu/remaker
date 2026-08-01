namespace Assets.Scripts.Core.Skills
{
	public class FreezeBuff : Buff
	{
		private bool playMaterialVfx;

		private bool playLockVfx;

		public FreezeBuff(BuffType type, BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, bool playMaterialVfx, bool playLockVfx, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
