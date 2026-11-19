using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public abstract class NetworkTransformBase : NetworkBehaviour
{
	[Tooltip("The Transform component to sync. May be on on this GameObject, or on a child.")]
	[Header("Target")]
	public Transform target;

	public readonly SortedList<double, TransformSnapshot> clientSnapshots;

	public readonly SortedList<double, TransformSnapshot> serverSnapshots;

	[Header("Selective Sync\nDon't change these at Runtime")]
	public bool syncPosition;

	public bool syncRotation;

	public bool syncScale;

	[Tooltip("When true, changes are not sent unless greater than sensitivity values below.")]
	[Header("Bandwidth Savings")]
	public bool onlySyncOnChange;

	[Tooltip("Apply smallest-three quaternion compression. This is lossy, you can disable it if the small rotation inaccuracies are noticeable in your project.")]
	public bool compressRotation;

	[Header("Interpolation")]
	[Tooltip("Set to false to have a snap-like effect on position movement.")]
	public bool interpolatePosition;

	[Tooltip("Set to false to have a snap-like effect on rotations.")]
	public bool interpolateRotation;

	[Tooltip("Set to false to remove scale smoothing. Example use-case: Instant flipping of sprites that use -X and +X for direction.")]
	public bool interpolateScale;

	[Header("Coordinate Space")]
	[Tooltip("Local by default. World may be better when changing hierarchy, or non-NetworkTransforms root position/rotation/scale values.")]
	public CoordinateSpace coordinateSpace;

	[Tooltip("Add a small timeline offset to account for decoupled arrival of NetworkTime and NetworkTransform snapshots.\nfixes: https://github.com/MirrorNetworking/Mirror/issues/3427")]
	[Header("Timeline Offset")]
	public bool timelineOffset;

	[Header("Debug")]
	public bool showGizmos;

	public bool showOverlay;

	public Color overlayColor;

	protected bool IsClientWithAuthority => false;

	public uint sendIntervalMultiplier => 0u;

	protected double timeStampAdjustment => 0.0;

	protected double offset => 0.0;

	public Vector3 velocity { get; private set; }

	public Vector3 angularVelocity { get; private set; }

	protected override void OnValidate()
	{
	}

	protected virtual void Configure()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual Vector3 GetPosition()
	{
		return default;
	}

	protected virtual Quaternion GetRotation()
	{
		return default;
	}

	protected virtual Vector3 GetScale()
	{
		return default;
	}

	protected virtual void SetPosition(Vector3 position)
	{
	}

	protected virtual void SetRotation(Quaternion rotation)
	{
	}

	protected virtual void SetScale(Vector3 scale)
	{
	}

	protected virtual TransformSnapshot Construct()
	{
		return default;
	}

	protected void AddSnapshot(SortedList<double, TransformSnapshot> snapshots, double timeStamp, Vector3? position, Quaternion? rotation, Vector3? scale)
	{
	}

	protected virtual void Apply(TransformSnapshot interpolated, TransformSnapshot endGoal)
	{
	}

	[Command]
	public void CmdTeleport(Vector3 destination)
	{
	}

	[Command]
	public void CmdTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	[ClientRpc]
	public void RpcTeleport(Vector3 destination)
	{
	}

	[ClientRpc]
	public void RpcTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	[Server]
	public void ServerTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	[ClientRpc]
	private void RpcResetState()
	{
	}

	protected virtual void OnTeleport(Vector3 destination)
	{
	}

	protected virtual void OnTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	public virtual void ResetState()
	{
	}

	public virtual void Reset()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	[ServerCallback]
	private void OnClientAuthorityChanged(NetworkConnectionToClient conn, NetworkIdentity identity, bool authorityState)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdTeleport__Vector3(Vector3 destination)
	{
	}

	protected static void InvokeUserCode_CmdTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation)
	{
	}

	protected static void InvokeUserCode_CmdTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcTeleport__Vector3(Vector3 destination)
	{
	}

	protected static void InvokeUserCode_RpcTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation)
	{
	}

	protected static void InvokeUserCode_RpcTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcResetState()
	{
	}

	protected static void InvokeUserCode_RpcResetState(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkTransformBase()
	{
	}
}
