using System;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class MediatedBy : Attribute
{
	public Type MediatorType { get; set; }

	public MediatedBy(Type t)
	{
	}
}
