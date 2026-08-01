using System.Collections.Generic;
using Assets.Scripts.Ssar.TestDungeon;
using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.Test
{
	public class TestRaidScene : MonoBehaviour
	{
		private class SeperateData
		{
			public List<ISkillStat> row1;

			public List<ISkillStat> row2;

			public List<ISkillStat> row3;
		}

		public UIInput lab;

		public UIInput groupId;

		public UIInput subId;

		public UIInput level;

		public UIInput helmet;

		public UIInput armor;

		public UIInput pant;

		public UIInput weapon;

		public UIInput amulet;

		public UIInput ring;

		public UIInput petGroupId;

		public UIInput petSubId;

		public UIPopupList PopupList;

		public UILabel lb_difficulty;

		public UILabel lb_stat;

		public GameObject btn_raid;

		public UITable table_signature;

		public UITable table_passive;

		public GameObject btn_back;

		private TestDungeonActiveSkill[] activeSkills;

		private TestDungeonSignatureSkillView[] signatureSkillViews;

		private TestDungeonPassiveSkill[] passiveSkills;

		private void EnterArena(GameObject go)
		{
		}

		private void EnterRaid(GameObject o)
		{
		}

		private RaidTeamData GetCompanions()
		{
			return null;
		}

		private void GenerateData()
		{
		}

		private int Comparer(CharacterActiveSkillStat a, CharacterActiveSkillStat b)
		{
			return 0;
		}

		private ScenarioDifficulty Difficulty()
		{
			return default(ScenarioDifficulty);
		}

		private void GenerateSave()
		{
		}

		private void UpdateData(bool isInit = false)
		{
		}

		private void UpdatePet(MainCharacterData mainCharacterData, int petGroupId, int petSubId)
		{
		}

		private EquipmentConfigId GenerateEquipmentData(EquipmentType equipmentType, StatType statType, UIInput input, int groupId, int subId)
		{
			return null;
		}

		private void UpdateSkill(int groupId, int subId, int characterlevel, bool init)
		{
		}

		private SeperateData SeprateSignatureSkill(List<CharacterSignatureSkillStat> characterSignatureSkillStats)
		{
			return null;
		}

		private SeperateData SeperatePassiveSkill(List<CharacterPassiveSkillStat> characterPassiveSkillStats)
		{
			return null;
		}

		private void UpdateSkill2(int groupId, int subId, int characterLevel, bool init, SeperateData seperateData, TestDungeonSignatureSkillView[] views)
		{
		}

		private void SaveSkill(int groupId, int subId, int level)
		{
		}

		private string GetSkillDesc(int groupId, int subId, int level, SkillEquippedData data)
		{
			return null;
		}
	}
}
