using System;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

public class SpineDashShadow : MonoBehaviour
{
	public class Illusion
	{
		public GameObject go;

		public float duration;

		public float fadeTime;

		public List<Material> mats;
	}

	[Serializable]
	public class IllusionFrameData
	{
		public string animationName;

		public int startFrame;

		public int endFrame;
	}

	public GameObject prefab;

	public int MaxInstances;

	public int Rate;

	public float InstanceLiveTime;

	public float ReservedTime;

	public Material material;

	public string AlphaName;

	public AnimationCurve AlphaOverLifeTime;

	public IllusionFrameData[] frameDatas;

	private List<Illusion> illus;

	private List<Illusion> pool;

	private float Cooldown2SpawnInstance;

	private float countCD;

	private float countReservedTime;

	private SkeletonAnimation animation;

	private Vector3 lastPos;

	private Quaternion lastRot;

	private Dictionary<string, IllusionFrameData> mapFrameData;

	private int countfind;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool CanSpawn(GameObject go)
	{
		return false;
	}

	private void Sample(GameObject go)
	{
	}

	private string GetCurrentPlayingAnimationClip(SkeletonAnimation ani)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void ReturnIllusion(int index)
	{
	}

	private Illusion InstanceIllusion(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	private MeshRenderer findRenderer(GameObject parent)
	{
		return null;
	}
}
