using System.Collections.Generic;
using UnityEngine;

public class SimpleWrapContent : UIWrapContent
{
	private List<WrapContentData> data;

	private bool isInit;

	private bool instantiate;

	private WraptContentInstantiateChild instantiateChild;

	public virtual void Setup(List<WrapContentData> data, WraptContentInstantiateChild instantiateChild = null)
	{
	}

	private void CheckInit()
	{
	}

	protected override void UpdateItem(Transform item, int index, UpdateItemPivot pivot)
	{
	}

	protected override bool CheckUpdateItem(int index, UpdateItemPivot pivot)
	{
		return false;
	}

	public List<WrapContentData> GetData()
	{
		return null;
	}
}
