namespace Assets.Scripts.Core.Skills
{
	public class MovementSpeedBuff : Buff
	{
		private float bonus;

		private bool playVfx;

		public float Bonus => 0f;

		public bool PlayVfx => false;

		public MovementSpeedBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill, bool playVfx)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetBonus(float bonus)
		{
		}
	}
}
