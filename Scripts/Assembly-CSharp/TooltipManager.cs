using UnityEngine;
using UnityEngine.UI;

public class TooltipManager : MonoBehaviour
{
	[Header("Components")]
	public Text tooltip;

	public CanvasGroup canvasGroup;

	[Header("Properties")]
	public Vector2 margin;

	private RectTransform rectTransform;

	private Vector2 mousePosition;

	private float timer;

	private string artificial;

	private Tooltip currentTooltip;

	private float tooltipTimer;

	public static TooltipManager instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private Tooltip FindTooltip()
	{
		return null;
	}

	private void ShowTooltip(bool _visible)
	{
	}

	public void TooltipPosition()
	{
	}

	public void Set(string _text)
	{
	}

	public void Reset()
	{
	}

	public static void AddTooltip(GameObject _object, string _text)
	{
	}
}
