namespace SSAR.Dungeon.View
{
	public interface IModifierVisualInfo
	{
		float TimeRemaining();

		ModifierVisualType Type();

		bool IsPassive();

		bool HasCustomIcon();

		string Icon();

		bool HasCustomText();

		string Text();
	}
}
