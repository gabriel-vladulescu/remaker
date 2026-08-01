using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillDescriptionContainer : MonoBehaviour
	{
		public UILabel lb_skillDesc;

		public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
		}

		private string GetText(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
			return null;
		}

		private string GetDamageType(CharacterActiveSkillStat activeSkillStat)
		{
			return null;
		}

		private string GetPower(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
			return null;
		}

		private void GetPower(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset, out int basePower, out int bonusPower)
		{
			basePower = default(int);
			bonusPower = default(int);
		}

		private string GetCooldown(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
			return null;
		}

		private float GetPowerRuneBonus(int runeLevel, CharacterActiveSkillStat activeSkillStat)
		{
			return 0f;
		}

		private float GetPowerRuneBonus(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
			return 0f;
		}

		private float GetRuneCooldown(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, Preset preset)
		{
			return 0f;
		}

		private float GetEquipmentPowerBonus(MainCharacterData mainCharacterData, CharacterActiveSkillStat characterActiveSkillStat)
		{
			return 0f;
		}

		private float GetEquipmentCooldownReduction(MainCharacterData mainCharacterData, CharacterActiveSkillStat characterActiveSkillStat)
		{
			return 0f;
		}
	}
}
