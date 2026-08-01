using Artemis;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public class AncientChargeCooldown : Cooldown
	{
		private readonly string skillId;

		private readonly Entity entity;

		private TimeCooldown timeCooldown;

		private SkillComponent skillComp;

		public AncientChargeCooldown(string skillId, Entity entity, float cdDuration)
		{
		}

		public void Start()
		{
		}

		public float RemainingPercentage()
		{
			return 0f;
		}

		public float Remaining()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public bool IsComplete()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public void Reset()
		{
		}

		public void AdjustRemainingWithRatio(float value)
		{
		}

		public void AdjustRemainingWithRawValue(float value)
		{
		}

		public void AdjustDurationWithRatio(float value)
		{
		}
	}
}
