using Assets.Scripts.Ssar.MemoryShard;
using UnityEngine;

public class MemoryShardPopup : BasePopup
{
	public CharacterMirrorContainer CharacterMirrorContainer;

	public ClipStoryContainer ClipStoryContainer;

	public MemoryShardPopupTabView[] TabViews;

	public GameObject resourcesContaine;

	protected override void Awake()
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void OnDisable()
	{
	}

	public void Show()
	{
	}

	private void ChangeTab(MemoryShardPopupTabType tabType)
	{
	}

	private void InitTab()
	{
	}

	private void InitWhenShow()
	{
	}

	private void InitResources()
	{
	}
}
