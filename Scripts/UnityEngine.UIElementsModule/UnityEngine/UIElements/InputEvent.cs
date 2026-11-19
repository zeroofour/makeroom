namespace UnityEngine.UIElements;

public class InputEvent : EventBase<InputEvent>
{
	protected string previousData { set; }

	protected string newData { set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static InputEvent GetPooled(string previousData, string newData)
	{
		return null;
	}
}
