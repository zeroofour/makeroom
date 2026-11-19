using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VirtualMouse : MonoBehaviour
{
	public enum HoveringType
	{
		None = 0,
		KenneyButton = 1,
		ButtonEffect = 2,
		ButtonTrigger = 3
	}

	public PlayerInput input;

	public RawImage cursorIcon;

	private Transform hovering;

	private HoveringType hoveringType;

	private float margin;

	private bool usingVirtualMouse;

	private Vector2 position;

	private Vector2 virtualPosition;

	private Vector2 snappedPosition;

	private bool isSnapped;

	private float snapDistance;

	private float snapBreakDistance;

	private EventTrigger lastEventTrigger;

	public static VirtualMouse instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private bool IsInteractable(GameObject _object)
	{
		return false;
	}

	private void HoverOver()
	{
	}

	private void HoverReset()
	{
	}

	public void SwitchVirtualMouse(bool _usingVirtualMouse)
	{
	}

	public Vector2 GetPosition()
	{
		return default;
	}

	public bool HoveringOverUI()
	{
		return false;
	}

	public void Set(Texture2D _texture)
	{
	}
}
