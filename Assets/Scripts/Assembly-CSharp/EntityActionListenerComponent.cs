using System.Runtime.CompilerServices;
using Artemis.Interface;
using SSAR.BattleSystem.AI;

public class EntityActionListenerComponent : IComponent
{
	public delegate void OnCallBack(EntityAction action);

	private event OnCallBack On_Callback;

	public void Add(OnCallBack onCallBack)
	{
	}

	public void Remove(OnCallBack onCallBack)
	{
	}

	public void NotifyAction(EntityAction action)
	{
	}
}
