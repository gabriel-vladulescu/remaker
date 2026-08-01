using Scripts.Config;
using Scripts.Config.Stats;

public abstract class AbsHeroData
{
	public int level;

	public int groupId { get; set; }

	public int subId { get; set; }

	public AbsHeroData(int groupId, int subId, int level)
	{
		this.groupId = groupId;
		this.subId = subId;
		this.level = level;
	}

	public abstract EntityAbilities GetTotalStats();

	public abstract HeroBasicStats GetHeroBasicStats();

	public abstract HeroLevelStats GetHeroLevelStats();
}
