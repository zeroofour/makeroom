using UnityEngine;
using UnityEngine.UI;

public class ToolbarElement : MonoBehaviour
{
	[Header("Components")]
	public Image icon;

	public Tooltip tooltip;

	public void Set(ToolbarItem _item)
	{
	}

	public void Set(Sprite _sprite, Color _color)
	{
	}

	private void OnEnable()
	{
	}
}
