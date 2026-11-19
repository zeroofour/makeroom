using UnityEngine;
using UnityEngine.UI;

public class InputPromptSprite : MonoBehaviour
{
	[Header("Properties")]
	public string id;

	public bool hideWhenIncompatible;

	[Header("Components")]
	public Text label;

	private Image image;

	private CanvasGroup canvasGroup;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Set(string _id)
	{
	}

	public void UpdateSprite(InputDeviceType _device)
	{
	}

	public void SetSprite(Sprite _sprite)
	{
	}
}
