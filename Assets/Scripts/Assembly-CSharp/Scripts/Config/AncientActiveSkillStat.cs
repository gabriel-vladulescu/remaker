namespace Scripts.Config
{
	public class AncientActiveSkillStat : ISkillStat
	{
		private SkillExtraStat[] minExtra;

		private SkillExtraStat[] maxExtra;

		public int groupId { get; set; }

		public int subId { get; set; }

		public int skillId { get; set; }

		public string name { get; set; }

		public double cooldown { get; set; }

		public double scalePower { get; set; }

		public double skillPower { get; set; }

		public int unlockLevel { get; set; }

		public string icon { get; set; }

		public int damageType { get; set; }

		public int order { get; set; }

		public string localizeName { get; set; }

		public string localizeDescription { get; set; }

		public int level { get; set; }

		public int maxCharge { get; set; }

		public double minCooldown { get; set; }

		public double maxCooldown { get; set; }

		public double minScalePower { get; set; }

		public double maxScalePower { get; set; }

		public int maxEnhancedLevel { get; set; }

		public string[] minExtraStats { get; set; }

		public string[] maxExtraStats { get; set; }

		public SkillExtraStat[] MinExtraStats => null;

		public SkillExtraStat[] MaxExtraStats => null;

		internal void Parse()
		{
		}
	}
}
