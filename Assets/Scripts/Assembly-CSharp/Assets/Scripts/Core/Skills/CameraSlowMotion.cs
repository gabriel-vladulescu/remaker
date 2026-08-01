namespace Assets.Scripts.Core.Skills
{
	public class CameraSlowMotion : CameraFx
	{
		private float timeScale;

		private float duration;

		public float TimeScale => 0f;

		public float Duration => 0f;

		public CameraSlowMotion(float timeScale, float duration)
			: base(default(CameraFxType))
		{
		}
	}
}
