using System.Diagnostics;

namespace UnityEngine.UIElements;

public abstract class ContextualMenuManager
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool displayMenuHandledOSX;

	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

	protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
}
