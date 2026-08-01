using System;
using strange.extensions.injector.api;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class Implements : Attribute
{
	public object Name { get; set; }

	public Type DefaultInterface { get; set; }

	public InjectionBindingScope Scope { get; set; }

	public Implements()
	{
	}

	public Implements(InjectionBindingScope scope)
	{
	}

	public Implements(Type t, InjectionBindingScope scope = InjectionBindingScope.SINGLE_CONTEXT)
	{
	}

	public Implements(InjectionBindingScope scope, object name)
	{
	}

	public Implements(Type t, InjectionBindingScope scope, object name)
	{
	}
}
