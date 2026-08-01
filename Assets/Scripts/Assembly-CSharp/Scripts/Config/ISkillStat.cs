namespace Scripts.Config
{
	public interface ISkillStat
	{
		int groupId { get; set; }

		int subId { get; set; }

		int skillId { get; set; }

		string name { get; set; }

		double cooldown { get; set; }

		double scalePower { get; set; }

		double skillPower { get; set; }

		int unlockLevel { get; set; }

		string icon { get; set; }

		int damageType { get; set; }

		int order { get; set; }

		string localizeName { get; set; }

		string localizeDescription { get; set; }
	}
}
