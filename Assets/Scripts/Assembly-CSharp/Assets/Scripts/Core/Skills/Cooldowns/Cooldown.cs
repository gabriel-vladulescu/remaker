namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public interface Cooldown
	{
		void Start();

		float RemainingPercentage();

		float Remaining();

		float Duration();

		bool IsComplete();

		void Update(float dt);

		void Reset();
	}
}
