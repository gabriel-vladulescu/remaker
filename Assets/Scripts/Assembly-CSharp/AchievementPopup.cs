using System.Collections.Generic;
using UnityEngine;

public class AchievementPopup : BasePopup
{
	public SimpleWrapContent table;

	public GameObject anchor;

	public UIScrollView ScrollView;

	public GameObject resources_container;

	private List<AchievementRowView> rowViews;

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

	public void Show()
	{
	}

	public void UpdateData()
	{
	}

	private void InitResources()
	{
	}

	private void InitRow()
	{
	}
}
