using UnityEngine;
using UnityEngine.Events;

public class Sidebar : MonoBehaviour
{
	[Header("Components")]
	public RectTransform sidebar;

	public RectTransform canvasRectTransform;

	[Header("Properties")]
	public bool closeOnDeselect;

	[Header("Events")]
	public UnityEvent onShow;

	public UnityEvent onHide;

	private float positionHidden;

	private bool visible;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Hide()
	{
	}

	public void Show(bool _sound = true)
	{
	}

	public void SetVisible()
	{
	}

	public void SetInvisible()
	{
	}

	public bool IsVisible()
	{
		return false;
	}

	public void Toggle()
	{
	}
}
