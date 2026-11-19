using UnityEngine;

namespace Mirror.Examples.Common;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
public class PlayerCamera : NetworkBehaviour
{
	private Camera mainCam;

	public Vector3 offset;

	public Vector3 rotation;

	private void Awake()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public override void OnStopLocalPlayer()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReleaseCamera()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
