using UnityEngine;
using UnityEngine.Events;

public class Modes : MonoBehaviour
{
	public static Mode mode;

	[Header("Events")]
	public UnityEvent onOpen;

	public UnityEvent onClose;

	public static Modes instance { get; private set; }

	private void Awake()
	{
	}

	public static void SetMode(Mode _mode)
	{
	}

	public static void ResetMode()
	{
	}
}
