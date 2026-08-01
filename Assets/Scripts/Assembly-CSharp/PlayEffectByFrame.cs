using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class PlayEffectByFrame : MonoBehaviour
{
	public delegate void OnSpawn(GameObject fx);

	[Serializable]
	public class EffectData
	{
		public FrameData[] frames;

		public AnimationClip clip;
	}

	[Serializable]
	public class FrameData
	{
		public int frame;

		public GameObject fxObj;

		public GameObject parent;

		public bool removeOnFinishClip;
	}

	public class QueueAction
	{
		public AnimationClip clip;

		public float time;

		public GameObject fxObj;

		public GameObject parent;

		public bool removeOnFinishClip;
	}

	public class FxParentData
	{
		public GameObject parent;

		public string clipName;

		public bool removeOnFinishClip;

		public FxParentData(QueueAction action, GameObject gameObject, AnimationState state)
		{
		}
	}

	public static int FPS;

	public bool playOnEnable;

	public bool changeLayer;

	public bool disableAllFxWhenParentDisable;

	public List<EffectData> effects;

	private Animation ani;

	private List<QueueAction> queue;

	private Dictionary<GameObject, FxParentData> playingEffects;

	private bool isPlayEffect;

	public event OnSpawn On_Spawn;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private bool IsPlayingAnimationClip(Animation ani, AnimationClip clip)
	{
		return false;
	}
}
