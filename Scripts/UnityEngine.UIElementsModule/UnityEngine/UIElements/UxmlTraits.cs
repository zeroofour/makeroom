namespace UnityEngine.UIElements;

public abstract class UxmlTraits
{
	protected bool canHaveAnyAttribute { set; }

	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
	{
	}
}
