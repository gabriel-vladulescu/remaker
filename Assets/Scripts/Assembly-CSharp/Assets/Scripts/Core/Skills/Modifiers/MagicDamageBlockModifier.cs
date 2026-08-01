using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class MagicDamageBlockModifier : Modifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			float Bonus();
		}

		private Info info;

		private HealthComponent healthComponent;

		private ModifierVfxManager vfxManager;

		private float elapsed;

		private float deltaMagicDamageBlock;

		public MagicDamageBlockModifier(Info info, Entity target)
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

		private void Deactivate()
		{
		}
	}
}
