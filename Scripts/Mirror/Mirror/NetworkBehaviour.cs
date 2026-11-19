using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/guides/networkbehaviour")]
[AddComponentMenu(null)]
public abstract class NetworkBehaviour : MonoBehaviour
{
	[HideInInspector]
	[Tooltip("Server Authority calls OnSerialize on the server and syncs it to clients.\n\nClient Authority calls OnSerialize on the owning client, syncs it to server, which then broadcasts it to all other clients.\n\nUse server authority for cheat safety.")]
	public SyncDirection syncDirection;

	[HideInInspector]
	[Tooltip("By default synced data is sent from the server to all Observers of the object.\nChange this to Owner to only have the server update the client that has ownership authority for this object")]
	public SyncMode syncMode;

	[Range(0f, 2f)]
	[Tooltip("Time in seconds until next change is synchronized to the client. '0' means send immediately if changed. '0.5' means only send changes every 500ms.\n(This is for state synchronization like SyncVars, SyncLists, OnSerialize. Not for Cmds, Rpcs, etc.)")]
	[HideInInspector]
	public float syncInterval;

	internal double lastSyncTime;

	protected readonly List<SyncObject> syncObjects;

	protected ulong syncVarDirtyBits;

	internal ulong syncObjectDirtyBits;

	private ulong syncVarHookGuard;

	public bool isServer => false;

	public bool isClient => false;

	public bool isLocalPlayer => false;

	public bool isServerOnly => false;

	public bool isClientOnly => false;

	public bool isOwned => false;

	public bool authority => false;

	public uint netId => 0u;

	public NetworkConnection connectionToServer => null;

	public NetworkConnectionToClient connectionToClient => null;

	public NetworkIdentity netIdentity { get; internal set; }

	public byte ComponentIndex { get; internal set; }

	internal bool HasSyncObjects()
	{
		return false;
	}

	protected virtual void OnValidate()
	{
	}

	protected bool GetSyncVarHookGuard(ulong dirtyBit)
	{
		return false;
	}

	protected void SetSyncVarHookGuard(ulong dirtyBit, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetSyncObjectDirtyBit(ulong dirtyBit)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetSyncVarDirtyBit(ulong dirtyBit)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDirty()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsDirty()
	{
		return false;
	}

	public void ClearAllDirtyBits()
	{
	}

	protected void InitSyncObject(SyncObject syncObject)
	{
	}

	protected void SendCommandInternal(string functionFullName, int functionHashCode, NetworkWriter writer, int channelId, bool requiresAuthority = true)
	{
	}

	protected void SendRPCInternal(string functionFullName, int functionHashCode, NetworkWriter writer, int channelId, bool includeOwner)
	{
	}

	protected void SendTargetRPCInternal(NetworkConnection conn, string functionFullName, int functionHashCode, NetworkWriter writer, int channelId)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void GeneratedSyncVarSetter<T>(T value, ref T field, ulong dirtyBit, Action<T, T> OnChanged)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void GeneratedSyncVarSetter_GameObject(GameObject value, ref GameObject field, ulong dirtyBit, Action<GameObject, GameObject> OnChanged, ref uint netIdField)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void GeneratedSyncVarSetter_NetworkIdentity(NetworkIdentity value, ref NetworkIdentity field, ulong dirtyBit, Action<NetworkIdentity, NetworkIdentity> OnChanged, ref uint netIdField)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void GeneratedSyncVarSetter_NetworkBehaviour<T>(T value, ref T field, ulong dirtyBit, Action<T, T> OnChanged, ref NetworkBehaviourSyncVar netIdField) where T : NetworkBehaviour
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool SyncVarGameObjectEqual(GameObject newGameObject, uint netIdField)
	{
		return false;
	}

	protected void SetSyncVarGameObject(GameObject newGameObject, ref GameObject gameObjectField, ulong dirtyBit, ref uint netIdField)
	{
	}

	protected GameObject GetSyncVarGameObject(uint netId, ref GameObject gameObjectField)
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool SyncVarNetworkIdentityEqual(NetworkIdentity newIdentity, uint netIdField)
	{
		return false;
	}

	public void GeneratedSyncVarDeserialize<T>(ref T field, Action<T, T> OnChanged, T value)
	{
	}

	public void GeneratedSyncVarDeserialize_GameObject(ref GameObject field, Action<GameObject, GameObject> OnChanged, NetworkReader reader, ref uint netIdField)
	{
	}

	public void GeneratedSyncVarDeserialize_NetworkIdentity(ref NetworkIdentity field, Action<NetworkIdentity, NetworkIdentity> OnChanged, NetworkReader reader, ref uint netIdField)
	{
	}

	public void GeneratedSyncVarDeserialize_NetworkBehaviour<T>(ref T field, Action<T, T> OnChanged, NetworkReader reader, ref NetworkBehaviourSyncVar netIdField) where T : NetworkBehaviour
	{
	}

	protected void SetSyncVarNetworkIdentity(NetworkIdentity newIdentity, ref NetworkIdentity identityField, ulong dirtyBit, ref uint netIdField)
	{
	}

	protected NetworkIdentity GetSyncVarNetworkIdentity(uint netId, ref NetworkIdentity identityField)
	{
		return null;
	}

	protected static bool SyncVarNetworkBehaviourEqual<T>(T newBehaviour, NetworkBehaviourSyncVar syncField) where T : NetworkBehaviour
	{
		return false;
	}

	protected void SetSyncVarNetworkBehaviour<T>(T newBehaviour, ref T behaviourField, ulong dirtyBit, ref NetworkBehaviourSyncVar syncField) where T : NetworkBehaviour
	{
	}

	protected T GetSyncVarNetworkBehaviour<T>(NetworkBehaviourSyncVar syncNetBehaviour, ref T behaviourField) where T : NetworkBehaviour
	{
		return null;
	}

	protected static bool SyncVarEqual<T>(T value, ref T fieldValue)
	{
		return false;
	}

	protected void SetSyncVar<T>(T value, ref T fieldValue, ulong dirtyBit)
	{
	}

	public virtual void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public virtual void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	private void SerializeSyncObjects(NetworkWriter writer, bool initialState)
	{
	}

	private void DeserializeSyncObjects(NetworkReader reader, bool initialState)
	{
	}

	protected virtual void SerializeSyncVars(NetworkWriter writer, bool initialState)
	{
	}

	protected virtual void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}

	public void SerializeObjectsAll(NetworkWriter writer)
	{
	}

	public void SerializeObjectsDelta(NetworkWriter writer)
	{
	}

	internal void DeserializeObjectsAll(NetworkReader reader)
	{
	}

	internal void DeserializeObjectsDelta(NetworkReader reader)
	{
	}

	internal void Serialize(NetworkWriter writer, bool initialState)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int ErrorCorrection(int size, byte safety)
	{
		return 0;
	}

	internal bool Deserialize(NetworkReader reader, bool initialState)
	{
		return false;
	}

	internal void ResetSyncObjects()
	{
	}

	public virtual void OnStartServer()
	{
	}

	public virtual void OnStopServer()
	{
	}

	public virtual void OnStartClient()
	{
	}

	public virtual void OnStopClient()
	{
	}

	public virtual void OnStartLocalPlayer()
	{
	}

	public virtual void OnStopLocalPlayer()
	{
	}

	public virtual void OnStartAuthority()
	{
	}

	public virtual void OnStopAuthority()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool Weaved()
	{
		return false;
	}
}
