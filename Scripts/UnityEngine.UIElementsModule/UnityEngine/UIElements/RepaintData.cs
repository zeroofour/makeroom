using System.Diagnostics;

namespace UnityEngine.UIElements;

internal class RepaintData
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Vector2 mousePosition;

	public Matrix4x4 currentOffset { get; }

	public Rect currentWorldClip { get; }

	public Event repaintEvent { get; set; }
}
