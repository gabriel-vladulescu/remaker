namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic
{
	public interface IDungeonInterfaceLogic
	{
		string GetDungeonName();

		string GetStageDesc();

		bool EnableStartWarning();

		string StartWarningMainText();

		string StartWarningSubText();
	}
}
