using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/Network Transform Hybrid")]
public class NetworkTransformHybrid : NetworkBehaviourHybrid
{
	public bool useFixedUpdate;

	private TransformSnapshot? pendingSnapshot;

	[Tooltip("The Transform component to sync. May be on this GameObject, or on a child.")]
	[Header("Target")]
	public Transform target;

	[Tooltip("Buffer size limit to avoid ever growing list memory consumption attacks.")]
	public int bufferSizeLimit;

	internal SortedList<double, TransformSnapshot> clientSnapshots;

	internal SortedList<double, TransformSnapshot> serverSnapshots;

	[Header("Synchronization")]
	[Tooltip("Send N snapshots per second. Multiples of frame rate make sense.")]
	public int sendRate;

	private Vector3 lastSerializedBaselinePosition;

	private Quaternion lastSerializedBaselineRotation;

	private Vector3 lastSerializedBaselineScale;

	private Vector3 lastDeserializedBaselinePosition;

	private Quaternion lastDeserializedBaselineRotation;

	private Vector3 lastDeserializedBaselineScale;

	[Header("Sensitivity")]
	[Tooltip("Sensitivity of changes needed before an updated state is sent over the network")]
	public float positionSensitivity;

	public float rotationSensitivity;

	public float scaleSensitivity;

	[Header("Selective Sync & interpolation")]
	public bool syncPosition;

	public bool syncRotation;

	public bool syncScale;

	[Header("Debug")]
	public bool debugDraw;

	public bool showGizmos;

	public bool showOverlay;

	public Color overlayColor;

	public float sendInterval => 0f;

	public Vector3 velocity { get; private set; }

	public Vector3 angularVelocity { get; private set; }

	protected virtual void Awake()
	{
	}

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	protected virtual void ApplySnapshot(TransformSnapshot interpolated)
	{
	}

	protected override void StoreState()
	{
	}

	protected override bool StateChanged()
	{
		return false;
	}

	protected override void OnSerializeBaseline(NetworkWriter writer)
	{
	}

	protected override void OnDeserializeBaseline(NetworkReader reader, byte baselineTick)
	{
	}

	protected override void OnSerializeDelta(NetworkWriter writer)
	{
	}

	protected override void OnDeserializeDelta(NetworkReader reader, byte baselineTick)
	{
	}

	protected virtual void OnClientToServerDeltaSync(Vector3? position, Quaternion? rotation, Vector3? scale)
	{
	}

	protected virtual void OnServerToClientDeltaSync(Vector3? position, Quaternion? rotation, Vector3? scale)
	{
	}

	private void UpdateServerInterpolation()
	{
	}

	private void UpdateClientInterpolation()
	{
	}

	protected override void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	protected virtual void OnTeleport(Vector3 destination)
	{
	}

	protected virtual void OnTeleport(Vector3 destination, Quaternion rotation)
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

	[Command]
	public void CmdTeleport(Vector3 destination)
	{
	}

	[Command]
	public void CmdTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	[Server]
	public void ServerTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	public override void ResetState()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public override void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public override bool Weaved()
	{
		return false;
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

	static NetworkTransformHybrid()
	{
	}
}
