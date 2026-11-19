using UnityEngine;

public class Selection : MonoBehaviour
{
	[Header("Components")]
	public SpriteRenderer floor;

	public SpriteRenderer top;

	[Header("Properties")]
	public Sprite overrideSprite;

	[HideInInspector]
	public Bounds bounds;

	private GameObject target;

	public static Selection instance { get; private set; }

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Select(GameObject _target)
	{
	}

	public void UpdateSize()
	{
	}

	public void UpdateSizeCustom(SelectionCustom _selectionCustom)
	{
	}

	public void UpdatSizeBounds()
	{
	}
}
