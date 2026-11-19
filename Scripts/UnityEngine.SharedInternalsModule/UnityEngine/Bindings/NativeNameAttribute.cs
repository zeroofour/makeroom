using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
internal class NativeNameAttribute : Attribute
{
	public string Name { set; }

	public NativeNameAttribute(string name)
	{
	}
}
