using UnityEngine;
using UnityEngine.Events;

public class Toggler : MonoBehaviour
{
	[Header("Properties")]
	public bool defaultState;

	[Header("Components")]
	public CanvasGroup canvasGroup;

	public UnityEvent<bool> onToggle;

	private bool active;

	private void Awake()
	{
	}

	public void Toggle()
	{
	}

	public void SetActive(bool _active)
	{
	}

	private void Render()
	{
	}
}
