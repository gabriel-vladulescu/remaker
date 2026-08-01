using UnityEngine;

public class WaitingResponsePopup : BasePopup
{
	private const float DELAY_TO_SHOW = 0.5f;

	private float time;

	private float time2;

	private bool isShowFx;

	private bool enoughTimeShow;

	private bool severResponse;

	private bool instance;

	private float minTimeToShow;

	public UIWidget container;

	public GameObject fxContainer;

	private ParticleSystem particleSystem;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(bool instance, float minTimeToShow = 0.2f)
	{
	}

	public void OnReceiveResponse()
	{
	}

	private void Update()
	{
	}

	private void CheckHide()
	{
	}
}
