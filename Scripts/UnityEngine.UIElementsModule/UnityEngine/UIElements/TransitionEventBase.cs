namespace UnityEngine.UIElements;

public abstract class TransitionEventBase<T> : EventBase<T> where T : TransitionEventBase<T>, new()
{
	public StylePropertyNameCollection stylePropertyNames { get; }

	protected double elapsedTime { set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
	{
		return null;
	}
}
