using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Method)]
[VisibleToOtherModules]
internal sealed class NativeWritableSelfAttribute : Attribute
{
	public bool WritableSelf { set; }
}
