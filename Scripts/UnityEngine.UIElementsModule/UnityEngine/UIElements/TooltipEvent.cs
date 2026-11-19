namespace UnityEngine.UIElements;

public class TooltipEvent : EventBase<TooltipEvent>
{
	public string tooltip { set; }

	public Rect rect { set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}
}
