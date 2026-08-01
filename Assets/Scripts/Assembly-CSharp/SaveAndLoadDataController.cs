using Assets.Scripts.Core.Scheduling;

public class SaveAndLoadDataController : SimTimeObserver
{
	private UserData target;

	private static string fileName;

	private static string fileName2;

	public static string[] pathFileBackup;

	private float time;

	private float[] timeBackup;

	public UserData LoadUserData()
	{
		return null;
	}

	public bool HasUserData()
	{
		return false;
	}

	public void SetTarget(UserData userData)
	{
	}

	public void Save()
	{
	}

	public void ForceSave()
	{
	}

	private void Save2()
	{
	}

	private void SaveFile(UserData userData, string filePath, bool backUp)
	{
	}

	public static string FilePath()
	{
		return null;
	}

	public static string FilePath2()
	{
		return null;
	}

	public void OnSimTime(uint dt)
	{
	}
}
