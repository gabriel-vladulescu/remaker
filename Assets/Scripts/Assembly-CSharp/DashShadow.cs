using System;
using System.Collections.Generic;
using UnityEngine;

public class DashShadow : MonoBehaviour
{
	public class Illusion
	{
		public GameObject go;

		public Animator animator;

		public Animation animation;

		public float duration;

		public float fadeTime;

		public List<Material> mats;

		public void DeActive()
		{
		}
	}

	[Serializable]
	public class IllusionFrameData
	{
		public AnimationClip animationClip;

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

	public string bodyRendererName;

	public string headRendererName;

	public string weaponRendererName;

	private List<Illusion> illus;

	private List<Illusion> pool;

	private float Cooldown2SpawnInstance;

	private float countCD;

	private float countReservedTime;

	private Vector3 lastPos;

	private Quaternion lastRot;

	private Dictionary<string, IllusionFrameData> mapFrameData;

	private bool permanentActive;

	private Animator _animator;

	private Animation _animation;

	private Transform _cacheTransform;

	private bool _hasAnimatorComponent;

	private bool _hasAnimationComponent;

	private string[] _animationStates;

	public bool ready;

	private Material materialInstance;

	private Dictionary<GameObject, SkinnedMeshRenderer> bodyRendererByParent;

	private Dictionary<GameObject, SkinnedMeshRenderer> headRendererByParent;

	private Dictionary<GameObject, SkinnedMeshRenderer> weaponRendererByParent;

	private static char PREFIX;

	private int countfind;

	private void Start()
	{
	}

	public void SetReady(bool value)
	{
	}

	protected void SetPermanentActive(bool value)
	{
	}

	private void Update()
	{
	}

	private bool CanSpawnPrefab()
	{
		return false;
	}

	private void Sample(Illusion illusion)
	{
	}

	private string GetCurrentPlayingAnimationClip(Animation anim)
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

	private SkinnedMeshRenderer findSkinnedMesh(GameObject parent)
	{
		return null;
	}

	private SkinnedMeshRenderer FindSkinnedMeshOfBody(GameObject parent)
	{
		return null;
	}

	private SkinnedMeshRenderer FindSkinnedMeshOfHead(GameObject parent)
	{
		return null;
	}

	private SkinnedMeshRenderer FindSkinnedMeshOfWeapon(GameObject parent)
	{
		return null;
	}
}
