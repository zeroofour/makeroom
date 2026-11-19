using System.Collections.Generic;
using Kenney;
using UnityEngine;

public class Menu : MonoBehaviour
{
	public enum Orientation
	{
		Horizontal = 0,
		Vertical = 1,
		Grid = 2
	}

	[Header("Properties")]
	public Orientation orientation;

	public bool reverseOrder;

	public bool enabledOnActivation;

	[Header("Components")]
	public Transform container;

	private int index;

	private List<Button> buttons;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void Previous()
	{
	}

	public void Next()
	{
	}

	public void Select()
	{
	}

	public void Set(Button _button)
	{
	}

	public void Set(int _new)
	{
	}

	public void Activate()
	{
	}

	private void PrepareMenu()
	{
	}
}
