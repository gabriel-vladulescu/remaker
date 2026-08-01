using System;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTools
{
	private static GameObject container;

	private static Dictionary<TutAnchorObject, GameObject> anchors;

	private static TweenAlpha bubblePopupTween;

	public static GameObject GetTutorialContainer()
	{
		return null;
	}

	public static void SetAnchorObj(TutAnchorObject key, GameObject obj)
	{
	}

	public static GameObject GetAnchorObj(TutAnchorObject key)
	{
		return null;
	}

	public static TweenAlpha GetBubblePopupTween()
	{
		return null;
	}

	public static int GetGroupId(Type type)
	{
		return 0;
	}

	private static void EmptyDelegate(TutorialKey key, TutorialStage stage)
	{
	}
}
