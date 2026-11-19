using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler
{
	public Image icon;

	public Image seasonal;

	[Header("Elements")]
	public GameObject tab;

	public GameObject glow;

	private int index;

	private new bool enabled;

	private LibraryCategory libraryCategory;

	private LibraryObject libraryObject;

	public void SetLibrary(PanelObjects _panel, LibraryCategory _category, LibraryObject _object = null)
	{
	}

	public LibraryCategory GetLibraryCategory()
	{
		return null;
	}

	public LibraryObject GetLibraryObject()
	{
		return null;
	}

	public void SetData(int _index, Sprite _sprite, Color _color, float _scale, Material _material = null)
	{
	}

	public void ToggleTab(bool _enabled)
	{
	}

	public void ToggleGlow(bool _enabled)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public void Enable()
	{
	}

	public void Disable(bool _color = true)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
