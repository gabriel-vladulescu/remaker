using UnityEngine;
using strange.extensions.command.impl;

public abstract class BaseShowPopupCmd : Command
{
	public override void Execute()
	{
	}

	protected T GetInstance<T>() where T : Component
	{
		return null;
	}

	private GameObject Instantiate()
	{
		return null;
	}

	protected virtual bool IsSetChildLayer()
	{
		return false;
	}

	protected virtual PopupCamera GetCamera()
	{
		return default(PopupCamera);
	}

	protected abstract string GetAssetPath();

	protected abstract string GetInjectName();
}
