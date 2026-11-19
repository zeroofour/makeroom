using System;
using UnityEngine;

namespace Mirror;

public abstract class NetworkBehaviourHybrid : NetworkBehaviour
{
	[Tooltip("Occasionally send a full reliable state to delta compress against. This only applies to Components with SyncMethod=Unreliable.")]
	public int baselineRate;

	protected double lastBaselineTime;

	protected double lastDeltaTime;

	private byte lastSerializedBaselineTick;

	private byte lastDeserializedBaselineTick;

	[Tooltip("Enable to send all unreliable messages twice. Only useful for extremely fast-paced games since it doubles bandwidth costs.")]
	public bool unreliableRedundancy;

	[Tooltip("When sending a reliable baseline, should we also send an unreliable delta or rely on the reliable baseline to arrive in a similar time?")]
	public bool baselineIsDelta;

	private bool changedSinceBaseline;

	[Header("Debug")]
	public bool debugLog;

	protected bool IsClientWithAuthority => false;

	public float baselineInterval => 0f;

	public virtual void ResetState()
	{
	}

	protected abstract void OnSerializeBaseline(NetworkWriter writer);

	protected abstract void OnDeserializeBaseline(NetworkReader reader, byte baselineTick);

	protected abstract void OnSerializeDelta(NetworkWriter writer);

	protected abstract void OnDeserializeDelta(NetworkReader reader, byte baselineTick);

	protected abstract void StoreState();

	protected abstract bool StateChanged();

	protected virtual void OnDrop(byte lastBaselineTick, byte baselineTick, NetworkReader reader)
	{
	}

	[ClientRpc(channel = 0)]
	private void RpcServerToClientBaseline(ArraySegment<byte> data)
	{
	}

	[ClientRpc(channel = 1)]
	private void RpcServerToClientDelta(ArraySegment<byte> data)
	{
	}

	[Command(channel = 0)]
	private void CmdClientToServerBaseline(ArraySegment<byte> data)
	{
	}

	[Command(channel = 1)]
	private void CmdClientToServerDelta(ArraySegment<byte> data)
	{
	}

	protected virtual void UpdateServerBaseline(double localTime)
	{
	}

	protected virtual void UpdateServerDelta(double localTime)
	{
	}

	protected virtual void UpdateServerSync()
	{
	}

	protected virtual void UpdateClientBaseline(double localTime)
	{
	}

	protected virtual void UpdateClientDelta(double localTime)
	{
	}

	protected virtual void UpdateClientSync()
	{
	}

	protected virtual void Update()
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

	protected void UserCode_RpcServerToClientBaseline__ArraySegment_00601(ArraySegment<byte> data)
	{
	}

	protected static void InvokeUserCode_RpcServerToClientBaseline__ArraySegment_00601(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcServerToClientDelta__ArraySegment_00601(ArraySegment<byte> data)
	{
	}

	protected static void InvokeUserCode_RpcServerToClientDelta__ArraySegment_00601(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdClientToServerBaseline__ArraySegment_00601(ArraySegment<byte> data)
	{
	}

	protected static void InvokeUserCode_CmdClientToServerBaseline__ArraySegment_00601(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdClientToServerDelta__ArraySegment_00601(ArraySegment<byte> data)
	{
	}

	protected static void InvokeUserCode_CmdClientToServerDelta__ArraySegment_00601(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkBehaviourHybrid()
	{
	}
}
