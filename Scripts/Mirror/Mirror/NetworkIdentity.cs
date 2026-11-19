using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mirror.RemoteCalls;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror;

[DisallowMultipleComponent]
[DefaultExecutionOrder(-1)]
[AddComponentMenu("Network/Network Identity")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-identity")]
public sealed class NetworkIdentity : MonoBehaviour
{
	public delegate void ClientAuthorityCallback(NetworkConnectionToClient conn, NetworkIdentity identity, bool authorityState);

	internal bool clientStarted;

	public readonly Dictionary<int, NetworkConnectionToClient> observers;

	[FormerlySerializedAs("m_SceneId")]
	[HideInInspector]
	public ulong sceneId;

	[SerializeField]
	[HideInInspector]
	private uint _assetId;

	[Tooltip("Prevents this object from being spawned / enabled on clients")]
	[FormerlySerializedAs("m_ServerOnly")]
	public bool serverOnly;

	internal bool destroyCalled;

	private NetworkConnectionToClient _connectionToClient;

	private const int MaxNetworkBehaviours = 64;

	[Tooltip("Visibility can overwrite interest management. ForceHidden can be useful to hide monsters while they respawn. ForceShown can be useful for score NetworkIdentities that should always broadcast to everyone in the world.")]
	[FormerlySerializedAs("visible")]
	public Visibility visibility;

	private NetworkIdentitySerialization lastSerialization;

	private static readonly Dictionary<ulong, NetworkIdentity> sceneIds;

	private static uint nextNetworkId;

	[CompilerGenerated]
	private static ClientAuthorityCallback m_clientAuthorityCallback;

	[SerializeField]
	[HideInInspector]
	private bool hasSpawned;

	internal static NetworkIdentity previousLocalPlayer;

	private bool hadAuthority;

	public bool isClient { get; internal set; }

	public bool isServer { get; internal set; }

	public bool isLocalPlayer { get; internal set; }

	public bool isServerOnly => false;

	public bool isClientOnly => false;

	public bool isOwned { get; internal set; }

	public uint netId { get; internal set; }

	public uint assetId
	{
		get
		{
			return 0u;
		}
		internal set
		{
		}
	}

	public NetworkConnection connectionToServer { get; internal set; }

	public NetworkConnectionToClient connectionToClient
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public NetworkBehaviour[] NetworkBehaviours { get; private set; }

	public bool SpawnedFromInstantiate { get; private set; }

	public static event ClientAuthorityCallback clientAuthorityCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	internal void HandleRemoteCall(byte componentIndex, ushort functionHash, RemoteCallType remoteCallType, NetworkReader reader, NetworkConnectionToClient senderConnection = null)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	internal static void ResetStatics()
	{
	}

	internal static void ResetClientStatics()
	{
	}

	internal static void ResetServerStatics()
	{
	}

	public static NetworkIdentity GetSceneIdentity(ulong id)
	{
		return null;
	}

	internal static uint GetNextNetworkId()
	{
		return 0u;
	}

	public static void ResetNextNetworkId()
	{
	}

	internal void InitializeNetworkBehaviours()
	{
	}

	private void ValidateComponents()
	{
	}

	internal void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public static uint AssetGuidToUint(Guid guid)
	{
		return 0u;
	}

	private void OnDestroy()
	{
	}

	internal void OnStartServer()
	{
	}

	internal void OnStopServer()
	{
	}

	internal void OnStartClient()
	{
	}

	internal void OnStopClient()
	{
	}

	internal void OnStartLocalPlayer()
	{
	}

	internal void OnStopLocalPlayer()
	{
	}

	private (ulong, ulong) ServerDirtyMasks(bool initialState)
	{
		return default;
	}

	private ulong ClientDirtyMask()
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool IsDirty(ulong mask, int index)
	{
		return false;
	}

	internal void SerializeServer(bool initialState, NetworkWriter ownerWriter, NetworkWriter observersWriter)
	{
	}

	internal void SerializeClient(NetworkWriter writer)
	{
	}

	internal bool DeserializeServer(NetworkReader reader)
	{
		return false;
	}

	internal void DeserializeClient(NetworkReader reader, bool initialState)
	{
	}

	internal NetworkIdentitySerialization GetServerSerializationAtTick(int tick)
	{
		return default;
	}

	internal void AddObserver(NetworkConnectionToClient conn)
	{
	}

	internal void ClearAllComponentsDirtyBits()
	{
	}

	internal void RemoveObserver(NetworkConnectionToClient conn)
	{
	}

	public bool AssignClientAuthority(NetworkConnectionToClient conn)
	{
		return false;
	}

	internal void SetClientOwner(NetworkConnectionToClient conn)
	{
	}

	public void RemoveClientAuthority()
	{
	}

	internal void ResetState()
	{
	}

	internal void NotifyAuthority()
	{
	}

	internal void OnStartAuthority()
	{
	}

	internal void OnStopAuthority()
	{
	}

	internal void ClearObservers()
	{
	}
}
