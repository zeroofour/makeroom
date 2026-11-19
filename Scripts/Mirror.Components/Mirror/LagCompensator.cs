using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/general/lag-compensation")]
[DisallowMultipleComponent]
[AddComponentMenu("Network/ Lag Compensation/ Lag Compensator")]
public class LagCompensator : NetworkBehaviour
{
	[Header("Components")]
	[Tooltip("The collider to keep a history of.")]
	public Collider trackedCollider;

	[Header("Settings")]
	public LagCompensationSettings lagCompensationSettings;

	private double lastCaptureTime;

	private readonly Queue<KeyValuePair<double, Capture3D>> history;

	[Header("Debugging")]
	public Color historyColor;

	[ServerCallback]
	protected virtual void Update()
	{
	}

	[ServerCallback]
	protected virtual void Capture()
	{
	}

	protected virtual void OnDrawGizmos()
	{
	}

	[ServerCallback]
	public virtual bool Sample(NetworkConnectionToClient viewer, out Capture3D sample)
	{
		sample = default;
		return false;
	}

	[ServerCallback]
	public virtual bool BoundsCheck(NetworkConnectionToClient viewer, Vector3 hitPoint, float toleranceDistance, out float distance, out Vector3 nearest)
	{
		distance = default;
		nearest = default;
		return false;
	}

	[ServerCallback]
	public virtual bool RaycastCheck(NetworkConnectionToClient viewer, Vector3 originPoint, Vector3 hitPoint, float tolerancePercent, int layerMask, out RaycastHit hit)
	{
		hit = default;
		return false;
	}

	public override bool Weaved()
	{
		return false;
	}
}
