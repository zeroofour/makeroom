using System.Runtime.InteropServices;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
[ComVisible(true)]
public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name;

	private string value;

	private string type;

	public DebuggerDisplayAttribute(string value)
	{
	}
}
