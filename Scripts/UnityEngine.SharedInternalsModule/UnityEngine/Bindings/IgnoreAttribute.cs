using System;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Field)]
internal class IgnoreAttribute : Attribute
{
	public bool DoesNotContributeToSize { set; }
}
