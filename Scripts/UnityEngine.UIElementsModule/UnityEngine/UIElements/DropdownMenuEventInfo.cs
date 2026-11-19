using System.Diagnostics;

namespace UnityEngine.UIElements;

public class DropdownMenuEventInfo
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly EventModifiers modifiers;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Vector2 mousePosition;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Vector2 localMousePosition;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly char character;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly KeyCode keyCode;

	public DropdownMenuEventInfo(EventBase e)
	{
	}
}
