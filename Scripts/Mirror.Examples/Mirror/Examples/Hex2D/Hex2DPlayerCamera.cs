using UnityEngine;

namespace Mirror.Examples.Hex2D;

[DisallowMultipleComponent]
[AddComponentMenu(null)]
public class Hex2DPlayerCamera : NetworkBehaviour
{
	private Camera mainCam;

	public Vector3 offset;

	public Vector3 rotation;

	[Header("Diagnostics")]
	[SerializeField]
	[ReadOnly]
	private HexSpatialHash2DInterestManagement.CheckMethod checkMethod;

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
