using UnityEngine;
using UnityEngine.Events;

public class Steam : MonoBehaviour
{
	[Header("Events")]
	public UnityEvent onConnected;

	public UnityEvent onFailed;

	[Header("Properties")]
	public string continueScene;

	public static bool active;

	public static bool initialized;

	public static GameObject target;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void Continue()
	{
	}

	public static void Achievement(string _id)
	{
	}

	public static void AddStat(string _id, int _count)
	{
	}

	public static void StoreStats()
	{
	}

	public static void AddScreenshot(string _path, int _width, int _height)
	{
	}

	public static bool ShowKeyboard(string _description = "Text", string _existingText = "", GameObject _target = null, int _maxChars = 256)
	{
		return false;
	}

	public static string GetKeyboardInput()
	{
		return null;
	}

	public void OnTextInputDismissed(bool _submitted)
	{
	}

	public static bool IsSteamDeck()
	{
		return false;
	}
}
