using System.Collections.Generic;
using UnityEngine;

public class PromotionalObjectsSlideshow : MonoBehaviour
{
	[Header("Components")]
	public Transform container;

	private Vector2 objectPosition;

	private float margin;

	private List<LibraryObject> objects;

	private List<GameObject> generated;

	private int index;

	private GameObject previousObject;

	private void Start()
	{
	}

	public void NextObject()
	{
	}
}
