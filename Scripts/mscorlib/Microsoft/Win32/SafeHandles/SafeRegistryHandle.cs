using System;

namespace Microsoft.Win32.SafeHandles;

public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	protected override bool ReleaseHandle()
	{
		return false;
	}

	internal SafeRegistryHandle()
		: base(ownsHandle: false)
	{
	}

	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle: false)
	{
	}
}
