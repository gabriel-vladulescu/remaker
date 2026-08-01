public class PointerTutParameter : ITutParameter
{
	public TutAnchorObject anchorObject;

	public TutPointerCompleteCondition condition;

	public PointerShapeTye shape;

	public bool canDrag;

	public bool canPress;

	public bool clone;

	public bool enableMask;

	public string text_tapHere;

	private bool requireTouchToTarget;

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

	public PointerTutParameter(TutAnchorObject anchor)
	{
	}

	public PointerTutParameter SetCanDrag()
	{
		return null;
	}

	public PointerTutParameter SetCanPress()
	{
		return null;
	}

	public PointerTutParameter SetTittle(string tittle)
	{
		return null;
	}

	public PointerTutParameter SetSize(int width, int height)
	{
		return null;
	}

	public PointerTutParameter SetClone()
	{
		return null;
	}

	public PointerTutParameter SetCompleteCondition(TutPointerCompleteCondition condition)
	{
		return null;
	}

	public PointerTutParameter SetShape(PointerShapeTye shape)
	{
		return null;
	}

	public PointerTutParameter SetDisableMask()
	{
		return null;
	}

	public PointerTutParameter DisableRequireTouchToTarget()
	{
		return null;
	}

	public PointerTutParameter SetTextTapHere(string text)
	{
		return null;
	}
}
