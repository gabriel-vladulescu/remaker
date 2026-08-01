using SSAR.SkillSystem.Model;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Achievement.Metrics;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class SaveCharacterSkillDataCmd : strange.extensions.command.impl.Command
	{
		private int groupId;

		private int subId;

		private int level;

		private RuneUpgradeListener runeUpgradeListener;

		[Inject]
		public SkillEquippedData CharacterSkillData { get; set; }

		[Inject]
		public Preset Preset { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		public override void Execute()
		{
		}

		private void ActiveSkill()
		{
		}

		private void SendMetricForActiveSkills(SkillConfigId sci, int powerRuneNow, int powerRuneBefore, int arcaneRuneNow, int arcaneRuneBefore, int tacticRuneNow, int tacticRuneBefore)
		{
		}

		private void SignatureSkill()
		{
		}

		private void SendMetricForSignatureSkill(CharacterSignatureSkillStat signatureSkillStat, int currentLevel, int levelBefore)
		{
		}

		private void PassiveSkill()
		{
		}

		private void SendMetricForPassiveSkill(CharacterPassiveSkillStat passiveSkillStat, int currentLevel, int levelBefore)
		{
		}

		private MainCharacterData MainCharacterData()
		{
			return null;
		}
	}
}
