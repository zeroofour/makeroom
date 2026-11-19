using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/Network Transform (Unreliable)")]
public class NetworkTransformUnreliable : NetworkTransformBase
{
	private uint sendIntervalCounter;

	private double lastSendIntervalTime;

	private TransformSnapshot? pendingSnapshot;

	[Header("Additional Settings")]
	[Tooltip("How much time, as a multiple of send interval, has passed before clearing buffers.\nA larger buffer means more delay, but results in smoother movement.\nExample: 1 for faster responses minimal smoothing, 5 covers bad pings but has noticable delay, 3 is recommended for balanced results.")]
	public float bufferResetMultiplier;

	public bool useFixedUpdate;

	[Tooltip("Sensitivity of changes needed before an updated state is sent over the network")]
	[Header("Sensitivity")]
	public float positionSensitivity;

	public float rotationSensitivity;

	public float scaleSensitivity;

	protected TransformSnapshot lastSnapshot;

	protected Changed cachedChangedComparison;

	protected bool hasSentUnchangedPosition;

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void CheckLastSendTime()
	{
	}

	private void UpdateServerBroadcast()
	{
	}

	private void UpdateServerInterpolation()
	{
	}

	private void UpdateClientBroadcast()
	{
	}

	private void UpdateClientInterpolation()
	{
	}

	public override void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	protected virtual void UpdateLastSentSnapshot(Changed change, TransformSnapshot currentSnapshot)
	{
	}

	protected virtual Changed CompareChangedSnapshots(TransformSnapshot currentSnapshot)
	{
		return Changed.None;
	}

	[Command(channel = 1)]
	private void CmdClientToServerSync(SyncData syncData)
	{
	}

	protected virtual void OnClientToServerSync(SyncData syncData)
	{
	}

	[ClientRpc(channel = 1)]
	private void RpcServerToClientSync(SyncData syncData)
	{
	}

	protected virtual void OnServerToClientSync(SyncData syncData)
	{
	}

	protected virtual void UpdateSyncData(ref SyncData syncData, SortedList<double, TransformSnapshot> snapshots)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdClientToServerSync__SyncData(SyncData syncData)
	{
	}

	protected static void InvokeUserCode_CmdClientToServerSync__SyncData(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcServerToClientSync__SyncData(SyncData syncData)
	{
	}

	protected static void InvokeUserCode_RpcServerToClientSync__SyncData(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkTransformUnreliable()
	{
	}
}
