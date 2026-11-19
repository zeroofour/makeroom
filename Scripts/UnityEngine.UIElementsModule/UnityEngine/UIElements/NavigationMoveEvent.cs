namespace UnityEngine.UIElements;

public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	public enum Direction
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4
	}

	public Direction direction { get; private set; }

	private Vector2 move { set; }

	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
	{
		return Direction.None;
	}

	public static NavigationMoveEvent GetPooled(Vector2 moveVector)
	{
		return null;
	}

	protected override void Init()
	{
	}
}
