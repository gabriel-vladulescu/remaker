using System;
using strange.extensions.injector.api;

[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class ImplementedBy : Attribute
{
	public Type DefaultType { get; set; }

	public InjectionBindingScope Scope { get; set; }

	public ImplementedBy(Type t, InjectionBindingScope scope = InjectionBindingScope.SINGLE_CONTEXT)
	{
	}
}
