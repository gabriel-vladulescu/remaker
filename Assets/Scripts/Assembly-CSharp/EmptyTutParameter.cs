public class EmptyTutParameter : ITutParameter
{
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
}
