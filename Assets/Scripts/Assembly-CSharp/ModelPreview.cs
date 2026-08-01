using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;

[AddComponentMenu("NGUI/Custom Behaviour/Model Preview")]
public class ModelPreview : View
{
	public static readonly string ANIMATION_DEFAULT;

	private float FADE_TIME;

	private int count;

	private string[] animationName;

	private float delayAutoPlay;

	public Animation animation;

	private BoxCollider boxCollider;

	private string time;

	private List<GameObject> backgroundFx;

	public string ANIMATION_START;

	protected override void Awake()
	{
	}

	private new void OnEnable()
	{
	}

	protected override void OnDestroy()
	{
	}

	private new void OnDisable()
	{
	}

	private new void Start()
	{
	}

	private void Update()
	{
	}

	private void GetAnimation()
	{
	}

	private void BackgroundFxShowOff()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnClick()
	{
	}
}
