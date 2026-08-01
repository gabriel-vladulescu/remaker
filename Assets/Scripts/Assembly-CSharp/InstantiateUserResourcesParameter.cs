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
	}

	public InstantiateUserResourcesParameter SetEnableBorder()
	{
		return null;
	}

	public InstantiateUserResourcesParameter DisableResources()
	{
		return null;
	}

	public InstantiateUserResourcesParameter DisableSetting()
	{
		return null;
	}

	public InstantiateUserResourcesParameter SetResourcesType(List<ResourceType> types)
	{
		return null;
	}
}
