using System.Collections.Generic;

public static class SoundUtils
{
	private static Dictionary<UISfx, SoundQuickSaveData> sfx;

	private static Dictionary<MusicScene, SoundQuickSaveData> bgm;

	private static Dictionary<Ambience, SoundQuickSaveData> ambience;

	private static void setupSfx()
	{
	}

	private static void setupBgm()
	{
	}

	private static void setupAmbience()
	{
	}

	public static SoundQuickSaveData GetQuickSaveData(UISfx uisfx)
	{
		return null;
	}

	public static SoundQuickSaveData GetQuickSaveData(MusicScene musicScene)
	{
		return null;
	}

	public static SoundQuickSaveData GetQuickSaveData(Ambience amb)
	{
		return null;
	}

	public static List<string> BgmFileName()
	{
		return null;
	}

	public static List<string> UiSfxFileName()
	{
		return null;
	}

	public static List<string> AmbienceFileName()
	{
		return null;
	}
}
