using UnityEngine;

public class SelectionBox : MonoBehaviour
{
	public Canvas canvas;

	private RectTransform box;

	private Vector2 mousePosition;

	public static SelectionBox instance { get; private set; }

	private void Awake()
	{
	}

	public void Select(Vector2 _mousePosition, Vector2 _delta)
	{
	}

	public void Complete()
	{
	}

	public void Cancel()
	{
	}

	private bool IsMouseInsideWindow()
	{
		return false;
	}

	private void OnApplicationFocus(bool _hasFocus)
	{
	}

	private void OnApplicationPause(bool _isPaused)
	{
	}
}
