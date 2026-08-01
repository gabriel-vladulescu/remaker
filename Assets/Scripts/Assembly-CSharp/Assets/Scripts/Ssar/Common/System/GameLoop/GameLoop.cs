using Assets.Scripts.Core.Scheduling;

namespace Assets.Scripts.Ssar.Common.System.GameLoop
{
	public interface GameLoop
	{
		void RegisterSimTimeObserver(SimTimeObserver observer);

		void UnregisterSimTimeObserver(SimTimeObserver observer);

		void RegisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer);

		void UnregisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer);

		void RegisterFrameTimeObserver(ViewFrameTimeObserver observer);

		void UnregisterFrameTimeObserver(ViewFrameTimeObserver observer);

		void RegisterClockTimeObserver(ClockTimeObserver observer, float tickSize);

		void UnregisterClockTimeObserver(ClockTimeObserver observer);

		void Scale(float scale);
	}
}
