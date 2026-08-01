using System.Collections.Generic;
using SSAR.SkillSystem.Model;

namespace Scripts.Config
{
	public class HeroConfig : AbsHeroConfig
	{
		public Dictionary<string, CharacterActiveSkillStat> characterActiveSkillStats;

		public Dictionary<string, CharacterSignatureSkillStat> signatureSkillStats;

		public Dictionary<string, CharacterPassiveSkillStat> passiveSkillStats;

		public Dictionary<string, HeroLevelStats> oldExp;

		public Dictionary<string, StatsCap> statsCaps;

		public Dictionary<string, HeroLevelStats> level_1_1;

		public Dictionary<string, HeroLevelStats> level_2_1;

		public Dictionary<string, HeroLevelStats> level_3_1;

		public Dictionary<string, HeroLevelStats> level_4_1;

		private Dictionary<string, List<HeroLevelStats>> listUserExp;

		private Dictionary<string, List<HeroLevelStats>> listUserExpOld;

		private Dictionary<string, List<CharacterActiveSkillStat>> activeSkillsByHeroGroupdAndSubId;

		private Dictionary<string, List<CharacterSignatureSkillStat>> signatureSkillsByHeroGroupAndSubId;

		private Dictionary<string, List<CharacterPassiveSkillStat>> passiveSkillsByHeroGroupAndSubId;

		private Dictionary<string, List<ISkillStat>> allSkillsByHeroGroupAndSubId;

		public Dictionary<string, ISkillStat> allSkillStats;

		private readonly string[] comboNames;

		private const string DASH = "Dash";

		private const string DASH_ATTACK = "DashAttack";

		private const string JUMP = "Jump";

		private const string JUMP_2ND = "Jump2nd";

		private static string[] jumpAttackNames;

		protected override void Map()
		{
		}

		public int SkillId(int order)
		{
			return 0;
		}

		public override HeroLevelStats FindHeroBasicStats(int groupId, int id, int level)
		{
			return null;
		}

		public bool FindStatsCap(int groupId, int subId, ref StatsCap statsCap)
		{
			return false;
		}

		public List<HeroLevelStats> GetListUserExp(int groupId, int subId)
		{
			return null;
		}

		public List<HeroLevelStats> GetListUserExpOld(int groupId, int subId)
		{
			return null;
		}

		public CharacterActiveSkillStat GetCharacterActiveSkillStat(string key)
		{
			return null;
		}

		public CharacterActiveSkillStat GetCharacterActiveSkillStat(int groupId, int subId, int skillId)
		{
			return null;
		}

		public List<CharacterActiveSkillStat> GetAllCharacterActiveSkillStats(int groupId, int subId)
		{
			return null;
		}

		public List<string> GetAllCharacterActiveSkillStatsId(int groupId, int subId)
		{
			return null;
		}

		public CharacterSignatureSkillStat GetCharacterSignatureSkillStat(string key)
		{
			return null;
		}

		public CharacterSignatureSkillStat GetCharacterSignatureSkillStat(int groupId, int subId, int skillId)
		{
			return null;
		}

		public List<CharacterSignatureSkillStat> GetAllSignatureSkillStats(int groupId, int subId)
		{
			return null;
		}

		public CharacterPassiveSkillStat GetCharacterPassiveSkillStat(string key)
		{
			return null;
		}

		public CharacterPassiveSkillStat GetCharacterPassiveSkillStat(int groupId, int subId, int skillId)
		{
			return null;
		}

		public List<CharacterPassiveSkillStat> GetAllPassiveSkillStats(int groupId, int subId)
		{
			return null;
		}

		public List<ISkillStat> GetSkillStatsListFromAllStatsLists(int groupId, int subId)
		{
			return null;
		}

		public ISkillStat GetSkillStatsFromAllStatsLists(int groupId, int subId, int skillId)
		{
			return null;
		}

		public bool IsActiveSkill(int groupId, int subId, int skillId)
		{
			return false;
		}

		public bool IsActiveSkill(string fullSkillId)
		{
			return false;
		}

		public bool IsSignatureSkill(int groupId, int subId, int skillId)
		{
			return false;
		}

		public bool IsSignatureSkill(string fullSkillId)
		{
			return false;
		}

		public bool IsPassiveSkill(int groupId, int subId, int skillId)
		{
			return false;
		}

		public bool IsPassiveSkill(string fullSkillId)
		{
			return false;
		}

		public List<string> ListCombos(int groupId, int subId)
		{
			return null;
		}

		public string Dash(int groupId, int subId)
		{
			return null;
		}

		public string DashAtk(int groupId, int subId)
		{
			return null;
		}

		public string Jump(int groupId, int subId)
		{
			return null;
		}

		public string SecondJump(int groupId, int subId)
		{
			return null;
		}

		public List<string> ListJumpAttacks(int groupId, int subId)
		{
			return null;
		}

		public List<string> ListActiveSkills(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfAttackIncreasePassiveSkill(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfCritDamagePassiveSkill(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfCritRatePassiveSkill(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfMaxHpPassiveSkill(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfDefPassiveSkill(int groupId, int subId)
		{
			return null;
		}

		public SkillConfigId SkillIdOfMagicResistPassiveSkill(int groupId, int subId)
		{
			return null;
		}

		private int CompareExp(object x, object y)
		{
			return 0;
		}

		private int ComparerSkill(object x, object y)
		{
			return 0;
		}

		private void MapExp(Dictionary<string, HeroLevelStats> dic, ref Dictionary<string, List<HeroLevelStats>> levelStatses)
		{
		}
	}
}
