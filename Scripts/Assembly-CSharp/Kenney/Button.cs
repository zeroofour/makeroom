using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kenney;

public class Button : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[Header("Properties")]
	public ButtonSound sound;

	public Sprite spriteHover;

	public Sprite spriteSelected;

	public Color colorHover;

	[Header("Animation")]
	public bool animate;

	public bool animateHover;

	public Transform animateTarget;

	[Header("Properties")]
	public bool defocusOnClick;

	public float deactivatedOpacity;

	public bool selector;

	[Header("Events")]
	public UnityEvent onClick;

	[HideInInspector]
	public bool active;

	[HideInInspector]
	public bool selected;

	[HideInInspector]
	public Menu menu;

	private Sprite spriteDefault;

	private Color colorDefault;

	private Image image;

	private void Awake()
	{
	}

	public void Select()
	{
	}

	public void Deselect()
	{
	}

	public void SimulateClick()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void Focus()
	{
	}

	public void Defocus()
	{
	}

	public void OnPointerClick(PointerEventData pointerEventData)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	public void SetActivation(bool _active)
	{
	}
}
