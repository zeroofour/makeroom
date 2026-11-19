using UnityEngine;

public class Prompts : MonoBehaviour
{
	public CanvasGroup overlay;

	public GameObject overlayClose;

	public Transform container;

	[HideInInspector]
	public string action;

	public static Prompts instance { get; private set; }

	private void Awake()
	{
	}

	public GameObject Open(string _id, string _action = "", string _message = "", GameObject _target = null, bool _close = false, bool _sound = true)
	{
		return null;
	}

	public void Animate()
	{
	}

	public bool CurrentlyOpen()
	{
		return false;
	}

	public void Close()
	{
	}

	public void AfterSaveConfirmation(string _type)
	{
	}
}
