using System.Collections.Generic;
using UnityEngine;

public class PromotionalObjectsGrid : MonoBehaviour
{
	[Header("Components")]
	public Transform container;

	private Vector2 objectPosition;

	private float margin;

	private List<LibraryObject> objects;

	private void Start()
	{
	}
}
