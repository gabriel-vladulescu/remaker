using System.Reflection;
using System.Text;

public class StaticString
{
	public enum CharAlignment
	{
		Left = 0,
		Right = 1
	}

	private static FieldInfo _sb_str_info;

	private StringBuilder _sb;

	public CharAlignment Alignment { get; set; }

	public string Value => null;

	public StaticString(int value, int size = 1)
	{
	}

	public void Set(int value)
	{
	}
}
