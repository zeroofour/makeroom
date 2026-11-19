using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ComponentInput : MonoBehaviour
{
	[Header("Options")]
	public bool replaceSpaces;

	[Header("Components")]
	public Text input;

	public UnityEvent<string> onChange;

	public void OpenInput()
	{
	}

	public void Set(string _message)
	{
	}

	public void SetUpdate(string _message = null)
	{
	}

	public string GetInput()
	{
		return null;
	}

	public static string Slugify(string _input)
	{
		return null;
	}
}
