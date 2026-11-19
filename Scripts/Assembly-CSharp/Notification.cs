using Pixelplacement.TweenSystem;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
	[Header("Components")]
	public Text label;

	public InputPromptSprite inputPromptSprite;

	private TweenBase tween;

	public static Notification instance { get; private set; }

	private void Awake()
	{
	}

	public void Show(string _text, string _input, float _time = 2f)
	{
	}

	public void Show(string _text, float _time = 2f)
	{
	}

	public void Hide()
	{
	}

	public void HideCompletely()
	{
	}
}
