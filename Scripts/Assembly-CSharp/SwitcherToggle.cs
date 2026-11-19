using UnityEngine;
using UnityEngine.Events;

public class SwitcherToggle : MonoBehaviour
{
	[Header("Properties")]
	public bool activated;

	[Header("Targets")]
	public GameObject checkmark;

	public UnityEvent<bool> onChange;

	private void Start()
	{
	}

	public void Toggle()
	{
	}

	public bool GetChecked()
	{
		return false;
	}

	private void Render()
	{
	}
}
