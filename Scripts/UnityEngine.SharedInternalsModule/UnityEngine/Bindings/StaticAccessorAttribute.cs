using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute
{
	public string Name { set; }

	public StaticAccessorType Type { set; }

	[VisibleToOtherModules]
	internal StaticAccessorAttribute(string name)
	{
	}

	public StaticAccessorAttribute(string name, StaticAccessorType type)
	{
	}
}
