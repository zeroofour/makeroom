using Kenney;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
	[Header("Properties")]
	public bool active;

	[Header("Components")]
	public PlayerInput input;

	public static Menu activeMenu;

	public static Button activeButton;

	public static MenuManager instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void InputHandle()
	{
	}

	public void Focus(Menu _menu, Button _button)
	{
	}

	public void Defocus()
	{
	}

	public static void Activate(Menu _menu)
	{
	}

	public static void Deactivate()
	{
	}
}
