using System;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateUserResourcesParameter
{
	public UserResourcesLeftCornerType CornerType;

	public GameObject parent;

	public Action onBack;

	public string title;

	public bool enableBorder;

	public bool enableSetting;

	public bool enableResources;

	public List<ResourceType> ResourceTypes;

	public InstantiateUserResourcesParameter(GameObject parent, UserResourcesLeftCornerType leftCornerType, Action onBack, string title)
	{
		this.parent = parent;
		CornerType = leftCornerType;
		this.onBack = onBack;
		this.title = title;
		enableResources = true;
		enableSetting = true;
	}

	public InstantiateUserResourcesParameter SetEnableBorder()
	{
		enableBorder = true;
		return this;
	}

	public InstantiateUserResourcesParameter DisableResources()
	{
		enableResources = false;
		return this;
	}

	public InstantiateUserResourcesParameter DisableSetting()
	{
		enableSetting = false;
		return this;
	}

	public InstantiateUserResourcesParameter SetResourcesType(List<ResourceType> types)
	{
		ResourceTypes = types;
		return this;
	}
}
