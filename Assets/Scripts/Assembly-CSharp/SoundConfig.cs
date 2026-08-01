using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/SoundConfig")]
public class SoundConfig : ScriptableObject
{
	public string[] uiSfxPath;

	public string[] bgmPath;

	public string[] ambiencePath;

	public float volume_normalAttack;

	public float volume_skill;

	public float volume_impact;

	public float volume_bgm;

	public float volume_button;

	public float volume_fx;

	public float volume_ambience;

	public string GetMusicPath(MusicScene scene)
	{
		return null;
	}

	public string GetAmbiencePath(Ambience ambience)
	{
		return null;
	}

	public string GetUISfxPath(UISfx uiSfx)
	{
		return null;
	}

	public float GetVolume(SoundGroup group)
	{
		return 0f;
	}

	public float GetVolume(UISfx uisfx)
	{
		return 0f;
	}
}
