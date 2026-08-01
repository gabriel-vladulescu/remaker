namespace Assets.Scripts.Config
{
	public interface RawDungeonConfig
	{
		RawDungeon GetDungeonInfo(int dungeonId);

		RawStage Stage(int id);
	}
}
