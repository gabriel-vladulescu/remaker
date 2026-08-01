using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public interface Modifier
	{
		string Name();

		ModifierType Type();

		float Duration();

		void Update(float dt);

		bool IsBuff();

		void OnReplaceOtherModifiers(Character character, List<Modifier> others);

		void OnBeReplaced(Character character);

		void OnAttach(Character character);

		void OnDetach(Character character);

		bool IsFinish();

		object[] Cookies();

		float TimeRemaining();

		void OnTargetTakingDamage(float damage);

		void OnCreateAsBuffFromSkill(Skill parentSkill);

		void OnCharacterDeath(Character deadCharacter);
	}
}
