using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
[VisibleToOtherModules]
internal class NativeConditionalAttribute : Attribute
{
	public string Condition { set; }

	public string StubReturnStatement { set; }

	public bool Enabled { set; }

	public NativeConditionalAttribute(string condition)
	{
	}

	public NativeConditionalAttribute(string condition, string stubReturnStatement)
	{
	}
}
