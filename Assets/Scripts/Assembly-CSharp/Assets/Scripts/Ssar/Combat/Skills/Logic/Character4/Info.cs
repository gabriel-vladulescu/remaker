using Assets.Scripts.Ssar.Combat.Skills.Logic.Character2;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character4
{
	public class Info
	{
		public int animationActiveFrame;

		public float playActiveAnimationnAt;

		public float stopCameraTrackingAt;

		public float startCameraTrackingAt;

		public float lockTargetAt;

		public float cameraMovingDuration;

		public string autoFindTargetMode;

		public float autoFindTargetRange;

		public Character2Skill8.AutoFindTargetMode ShowAutoFindTargetMode()
		{
			return default(Character2Skill8.AutoFindTargetMode);
		}
	}
}
