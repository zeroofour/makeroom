namespace UnityEngine.UIElements;

internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent>
{
	public enum Direction
	{
		None = 0,
		Next = 1,
		Previous = 2
	}

	private Direction direction { set; }

	internal static Direction DetermineMoveDirection(int moveValue)
	{
		return Direction.None;
	}

	public static NavigationTabEvent GetPooled(int moveValue)
	{
		return null;
	}

	protected override void Init()
	{
	}
}
