using System.Diagnostics;

namespace UnityEngine.UIElements;

public class DropdownMenuSeparator : DropdownMenuItem
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string subMenuPath;

	public DropdownMenuSeparator(string subMenuPath)
	{
	}
}
