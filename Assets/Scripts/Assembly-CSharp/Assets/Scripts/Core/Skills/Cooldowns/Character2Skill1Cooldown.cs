using Scripts.Config;

namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public class Character2Skill1Cooldown : Cooldown
	{
		private const int max_charge = 3;

		private readonly Character _character;

		private readonly HeroConfig _heroConfig;

		private int currentCharge;

		private int finishCounter;

		private TimeCooldown timeCooldown;

		private bool timeCooldownStarted;

		public Character2Skill1Cooldown(Character character, HeroConfig heroConfig, float duration)
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

		public void ConsumeAllCharges()
		{
		}

		private void OnCastSkillListener(int entityId, string skillId)
		{
		}

		private void OnSkillFinishListener(Skill s, string skillid)
		{
		}
	}
}
