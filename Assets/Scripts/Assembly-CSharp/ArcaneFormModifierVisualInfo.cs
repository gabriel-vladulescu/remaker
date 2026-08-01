using SSAR.Dungeon.View;

public class ArcaneFormModifierVisualInfo : IModifierVisualInfo
{
	private float remaining;

	public void UpdateReamingTime(float newRemainingTime)
	{
	}

	public float TimeRemaining()
	{
		return 0f;
	}

	public ModifierVisualType Type()
	{
		return default(ModifierVisualType);
	}

	public bool IsPassive()
	{
		return false;
	}

	public bool HasCustomIcon()
	{
		return false;
	}

	public string Icon()
	{
		return null;
	}

	public bool HasCustomText()
	{
		return false;
	}

	public string Text()
	{
		return null;
	}
}
