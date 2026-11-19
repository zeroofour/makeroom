using UnityEngine;

namespace Mirror.Examples.Common;

[AddComponentMenu(null)]
public class FPS : MonoBehaviour
{
	public bool showGUI;

	public bool showLog;

	private int count;

	private double startTime;

	public int framesPerSecond { get; private set; }

	protected void Update()
	{
	}

	protected void OnGUI()
	{
	}
}
