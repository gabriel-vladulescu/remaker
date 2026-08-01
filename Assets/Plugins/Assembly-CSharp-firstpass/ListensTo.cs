using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class ListensTo : Attribute
{
	public Type type { get; set; }

	public ListensTo()
	{
	}

	public ListensTo(Type t)
	{
	}
}
