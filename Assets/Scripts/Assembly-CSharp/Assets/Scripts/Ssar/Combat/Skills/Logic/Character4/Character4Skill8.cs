using Assets.Scripts.Core.Skills;
using Com.LuisPedroFonseca.ProCamera2D;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character4
{
	public class Character4Skill8 : DefaultMeleeSkill
	{
		private Info info;

		private bool activeAnimationPlayed;

		private bool isCameraStopTracking;

		private bool isCameraStartTracking;

		private bool isCameraStartTrackingCharacter;

		private bool isTargetLocked;

		private CameraTarget cameraTargetBack;

		public Character4Skill8(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnBeforeFinish()
		{
		}

		public override void OnFinish(Character character)
		{
		}
	}
}
