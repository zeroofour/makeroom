using UnityEngine;
using UnityEngine.Events;

public class Mode : MonoBehaviour
{
	[Header("Components")]
	public Sidebar sidebar;

	[Header("Events")]
	public UnityEvent onOpen;

	public UnityEvent onClose;

	public virtual void Open()
	{
	}

	public virtual void Close()
	{
	}
}
