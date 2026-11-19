using UnityEngine;
using UnityEngine.EventSystems;

public class DioramaAdvancedProperty : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	public DioramaAdvancedProperties advancedProperties;

	private bool isDragging;

	private Vector3 startingPosition;

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
