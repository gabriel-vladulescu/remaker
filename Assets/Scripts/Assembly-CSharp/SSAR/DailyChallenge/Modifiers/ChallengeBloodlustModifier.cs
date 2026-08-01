using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;

namespace Ssar.DailyChallenge.Modifiers
{
	public class ChallengeBloodlustModifier : Modifier
	{
		public class Info
		{
			private readonly float hpPerHitBonus;

			private readonly float dmgReceiveBonus;

			private readonly float duration;

			public float HpPerHitBonus => 0f;

			public float DmgReceiveBonus => 0f;

			public float Duration => 0f;

			public Info(float hpPerHitBonus, float dmgReceiveBonus, float duration)
			{
			}
		}

		private readonly Info info;

		private float elapsed;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		public ChallengeBloodlustModifier(Info info, Entity target)
		{
		}

		public string Name()
		{
			return null;
		}

		public ModifierType Type()
		{
			return default(ModifierType);
		}

		public float Duration()
		{
			return 0f;
		}

		public void Update(float dt)
		{
		}

		public bool IsBuff()
		{
			return false;
		}

		public void OnReplaceOtherModifiers(Character character, List<Modifier> others)
		{
		}

		public void OnBeReplaced(Character character)
		{
		}

		public void OnAttach(Character character)
		{
		}

		public void OnDetach(Character character)
		{
		}

		public bool IsFinish()
		{
			return false;
		}

		public object[] Cookies()
		{
			return null;
		}

		public float TimeRemaining()
		{
			return 0f;
		}

		public void OnTargetTakingDamage(float damage)
		{
		}

		public void OnCreateAsBuffFromSkill(Skill parentSkill)
		{
		}

		public void OnCharacterDeath(Character deadCharacter)
		{
		}
	}
}
