using SSAR.BattleSystem.Camera;

namespace Ssar.DailyChallenge.Component
{
	public class DailyChallengeCameraComponent : CameraComponent
	{
		protected override bool IsRequestValid(AbsCameraControlData request)
		{
			return false;
		}
	}
}
