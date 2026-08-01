using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Tutorial;

public class DialogTutParameter : ITutParameter
{
	public TutDisableWhenComplete disableWhenComplete;

	public int groupID;

	public int step;

	public int characterId;

	public List<NpcRequest> npcRequests;

	public Action onStart;

	public TutType type
	{
		get
		{
			return default(TutType);
		}
		set
		{
		}
	}

	public string tittle { get; set; }

	public float delayEnable { get; set; }

	public bool RequireTouchToTarget
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DisableMask
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DialogTutParameter(ITutorialGroup gGroup, int characterId, int step, NpcRequest npcRequests, TutDisableWhenComplete disableWhenComplete = TutDisableWhenComplete.ENABLE)
	{
	}

	public DialogTutParameter SetDelay(float second)
	{
		return null;
	}

	public DialogTutParameter SetDisableWhenCompleteMode(TutDisableWhenComplete tutDisableWhenComplete)
	{
		return null;
	}

	public DialogTutParameter AddSubNpc(NpcRequest npcRequest)
	{
		return null;
	}

	public List<NpcRequest> GetNpcRequests()
	{
		return null;
	}

	public DialogTutParameter SetActionOnStart(Action action)
	{
		return null;
	}
}
