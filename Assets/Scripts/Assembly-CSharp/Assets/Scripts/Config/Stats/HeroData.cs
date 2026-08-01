using System.Collections.Generic;
using Assets.Scripts.Mastery;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Utils;
using SSAR.Equipment.Model;
using SSAR.SkillSystem.Model;
using Scripts.Config;
using Scripts.Config.Stats;
using Ssar.Ancient.Model;

namespace Assets.Scripts.Config.Stats
{
	public class HeroData : AbsHeroData
	{
		protected ScenarioDifficulty Difficulty;

		protected EntityAbilities _mEntityAbilities;

		protected ConfigManager configManager;

		protected List<EquipmentCollectData> equipments;

		private CharacterSkillData characterSkillData;

		private bool shouldUpdatePowerAndCooldown;

		private List<WeaponActiveSkillData> weaponActiveSkillDatas;

		private bool shouldUpdatePassiveSkill;

		private List<PassiveSkill> weaponPassiveSkillsData;

		private PetData petData;

		private MasteryData masteryData;

		private bool shouldUpdateAncientSkill;

		private List<ChargedAncientSkill> ancientSkillsData;

		public HeroBasicStats HeroBasicStats => null;

		public HeroLevelStats HeroLevelStats => null;

		public HeroData(int groupId, int subId, int level, ConfigManager configManager)
			: base(0, 0, 0)
		{
		}

		public HeroData SetListEquipment(List<EquipmentCollectData> equipmentCollectDatas)
		{
			return null;
		}

		public HeroData SetPetData(PetData petData)
		{
			return null;
		}

		public HeroData SetMasteryData(MasteryData masteryData)
		{
			return null;
		}

		public bool FindPowerAndCooldownOfSkill(SkillConfigId skillConfigId, ref WeaponActiveSkillData wasd)
		{
			return false;
		}

		public List<PassiveSkill> ShowPassiveSkillsFromWeapons()
		{
			return null;
		}

		public bool FindPassiveSkillOf(string name, ref PassiveSkill ps)
		{
			return false;
		}

		public List<WeaponActiveSkillData> ShowPowerAndCooldownReductionFromWeapon()
		{
			return null;
		}

		public List<ChargedAncientSkill> GetAncientSkills()
		{
			return null;
		}

		public HeroData SetCharacterSkillData(CharacterSkillData skillData)
		{
			return null;
		}

		protected GetBasicAbilitiesParameter GetBasicAbilitiesParameter()
		{
			return null;
		}

		protected virtual bool IsHero()
		{
			return false;
		}

		public ConfigManager ConfigManager()
		{
			return null;
		}

		protected virtual IFindLevelStats FindLevelStats()
		{
			return null;
		}

		protected virtual IFindBasicStats FindBasicStats()
		{
			return null;
		}

		public override EntityAbilities GetTotalStats()
		{
			return null;
		}

		public override HeroBasicStats GetHeroBasicStats()
		{
			return null;
		}

		public override HeroLevelStats GetHeroLevelStats()
		{
			return null;
		}
	}
}
