using System.Diagnostics;

namespace UnityEngine.VFX;

public struct VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute)
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly int nameId = 0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly VFXEventAttribute eventAttribute = null;
}
