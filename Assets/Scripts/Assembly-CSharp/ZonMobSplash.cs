using System;
using UnityEngine;

// Shows the ZonMob studio logo (Resources/logo/zonmob_logo_white.png) full
// screen for a couple of seconds before the game's own UI (Title screen)
// takes over. Not part of the original game as reconstructed code - the
// real game presumably does this via a dedicated splash prefab/scene this
// project doesn't have evidence of (no prefab/material/scene statically
// references this texture, so it's likely loaded and drawn purely in code
// somewhere the decompiled stubs didn't preserve). Uses OnGUI rather than
// NGUI since it needs to render before any UICamera/UIRoot exists.
public class ZonMobSplash : MonoBehaviour
{
	private const string LogoResourcePath = "logo/zonmob_logo_white";
	private const float DisplaySeconds = 1.5f;

	private Texture2D logo;
	private float startTime;
	private Action onFinish;
	private bool finished;

	public void Show(Action onFinish)
	{
		this.onFinish = onFinish;
		logo = Resources.Load<Texture2D>(LogoResourcePath);
		startTime = Time.realtimeSinceStartup;

		if (logo == null)
		{
			Debug.LogWarning("[ZonMobSplash] Could not load " + LogoResourcePath + ", skipping splash.");
			Finish();
		}
	}

	private void Update()
	{
		if (!finished && logo != null && Time.realtimeSinceStartup - startTime >= DisplaySeconds)
		{
			Finish();
		}
	}

	private void Finish()
	{
		finished = true;
		enabled = false;
		onFinish?.Invoke();
	}

	private void OnGUI()
	{
		if (finished)
		{
			return;
		}

		GUI.depth = -1000;
		GUI.color = Color.black;
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), Texture2D.whiteTexture);

		if (logo == null)
		{
			return;
		}

		GUI.color = Color.white;
		float aspect = (float)logo.width / logo.height;
		float maxWidth = Screen.width * 0.5f;
		float width = maxWidth;
		float height = width / aspect;
		if (height > Screen.height * 0.5f)
		{
			height = Screen.height * 0.5f;
			width = height * aspect;
		}
		Rect rect = new Rect((Screen.width - width) * 0.5f, (Screen.height - height) * 0.5f, width, height);
		GUI.DrawTexture(rect, logo, ScaleMode.ScaleToFit);
	}
}
