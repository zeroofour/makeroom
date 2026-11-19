using System.Collections.Generic;
using Pixelplacement.TweenSystem;
using UnityEngine;

public class Toolbar : MonoBehaviour
{
	public GameObject element;

	public Selection selection;

	[Header("Sprites")]
	public Sprite spriteSingle;

	public Sprite spriteLeft;

	public Sprite spriteRight;

	[Header("Icons")]
	public Sprite spriteSwatch;

	public Sprite spriteSwatchLight;

	public ToolbarMenu[] menus;

	private GameObject target;

	private Vector3 targetPosition;

	private ToolbarMenu menu;

	private List<GameObject> generated;

	private int targetIndex;

	private string dynamicType;

	private TweenBase scaleTween;

	private bool visible;

	public static Toolbar instance { get; private set; }

	private void Awake()
	{
	}

	public bool Visible()
	{
		return false;
	}

	public void Show()
	{
	}

	public void Hide(bool _hideSelection = true)
	{
	}

	public void Reset()
	{
	}

	public void Set(GameObject _target, string _id, Vector3 _targetPosition, bool _hide = false)
	{
	}

	public void Generate()
	{
	}

	public void GenerateDynamic(bool _generate = true)
	{
	}

	private void Clear()
	{
	}

	public void UpdatePosition()
	{
	}

	public void Select(GameObject _object)
	{
	}

	public void Select(string _item)
	{
	}

	public void CheckColorWheel()
	{
	}

	public GameObject GetTarget()
	{
		return null;
	}

	public int GetTargetIndex()
	{
		return 0;
	}
}
