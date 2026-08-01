using System;

[Serializable]
public class UniWebViewEdgeInsets
{
	public int top;

	public int left;

	public int bottom;

	public int right;

	public UniWebViewEdgeInsets(int aTop, int aLeft, int aBottom, int aRight)
	{
	}

	public static bool operator ==(UniWebViewEdgeInsets inset1, UniWebViewEdgeInsets inset2)
	{
		return false;
	}

	public static bool operator !=(UniWebViewEdgeInsets inset1, UniWebViewEdgeInsets inset2)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
