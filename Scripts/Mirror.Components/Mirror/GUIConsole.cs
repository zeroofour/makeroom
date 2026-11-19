using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public class GUIConsole : MonoBehaviour
{
	public int height;

	public int offsetY;

	public int maxLogCount;

	public bool showInEditor;

	private readonly Queue<LogEntry> log;

	[Tooltip("Hotkey to show/hide the console at runtime\nBack Quote is usually on the left above Tab\nChange with caution - F keys are generally already taken in Browsers")]
	public KeyCode hotKey;

	private bool visible;

	private Vector2 scroll;

	private bool show => false;

	private void Awake()
	{
	}

	private void OnLog(string message, string stackTrace, LogType type)
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}
}
