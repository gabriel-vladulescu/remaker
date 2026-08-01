using Artemis;

namespace SSAR.BattleSystem.Camera
{
	public abstract class AbsCameraControlData
	{
		public CameraAccessLevel AccessLevel;

		public AbsCameraControlData(CameraAccessLevel accessLevelLevel)
		{
		}

		public virtual bool IsValid()
		{
			return false;
		}

		public abstract void Excute(Entity self);

		public abstract void Update(float deltaTime);

		public abstract bool Finished();

		public abstract void OnExit();
	}
}
