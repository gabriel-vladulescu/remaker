using System;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class Inject : Attribute
{
	public object name { get; set; }

	public Inject()
	{
	}

	public Inject(object n)
	{
	}
}
