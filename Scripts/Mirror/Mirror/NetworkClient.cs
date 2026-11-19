using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public static class NetworkClient
{
	private static double lastSendTime;

	public static bool exceptionsDisconnect;

	internal static readonly Dictionary<ushort, NetworkMessageDelegate> handlers;

	public static readonly Dictionary<uint, NetworkIdentity> spawned;

	public static bool ready;

	internal static ConnectState connectState;

	public static Action OnConnectedEvent;

	public static Action OnDisconnectedEvent;

	public static Action<TransportError, string> OnErrorEvent;

	public static Action<Exception> OnTransportExceptionEvent;

	public static readonly Dictionary<uint, GameObject> prefabs;

	internal static readonly Dictionary<uint, SpawnHandlerDelegate> spawnHandlers;

	internal static readonly Dictionary<uint, UnSpawnDelegate> unspawnHandlers;

	internal static bool isSpawnFinished;

	internal static readonly Dictionary<ulong, NetworkIdentity> spawnableObjects;

	internal static Unbatcher unbatcher;

	public static InterestManagementBase aoi;

	public static bool isLoadingScene;

	public static ConnectionQuality connectionQuality;

	public static ConnectionQuality lastConnectionQuality;

	public static ConnectionQualityMethod connectionQualityMethod;

	public static float connectionQualityInterval;

	private static double lastConnectionQualityUpdate;

	[CompilerGenerated]
	private static Action<ConnectionQuality, ConnectionQuality> m_onConnectionQualityChanged;

	private static readonly Dictionary<NetworkIdentity, SpawnMessage> pendingSpawns;

	public static SnapshotInterpolationSettings snapshotSettings;

	public static double bufferTimeMultiplier;

	public static SortedList<double, TimeSnapshot> snapshots;

	internal static double localTimeline;

	internal static double localTimescale;

	private static ExponentialMovingAverage driftEma;

	private static ExponentialMovingAverage deliveryTimeEma;

	public static int sendRate => 0;

	public static float sendInterval => 0f;

	public static NetworkConnectionToServer connection { get; internal set; }

	public static NetworkIdentity localPlayer { get; internal set; }

	public static bool active => false;

	public static bool activeHost => false;

	public static bool isConnecting => false;

	public static bool isConnected => false;

	public static double initialBufferTime => 0.0;

	public static double bufferTime => 0.0;

	[Obsolete("NeworkClient.dynamicAdjustment was moved to NetworkClient.snapshotSettings.dynamicAdjustment")]
	public static bool dynamicAdjustment => false;

	[Obsolete("NeworkClient.dynamicAdjustmentTolerance was moved to NetworkClient.snapshotSettings.dynamicAdjustmentTolerance")]
	public static float dynamicAdjustmentTolerance => 0f;

	[Obsolete("NeworkClient.dynamicAdjustment was moved to NetworkClient.snapshotSettings.dynamicAdjustment")]
	public static int deliveryTimeEmaDuration => 0;

	public static event Action<ConnectionQuality, ConnectionQuality> onConnectionQualityChanged
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

	private static void AddTransportHandlers()
	{
	}

	private static void RemoveTransportHandlers()
	{
	}

	private static void Initialize(bool hostMode)
	{
	}

	public static void Connect(string address)
	{
	}

	public static void Connect(Uri uri)
	{
	}

	public static void ConnectHost()
	{
	}

	public static void Disconnect()
	{
	}

	private static void OnTransportConnected()
	{
	}

	private static bool UnpackAndInvoke(NetworkReader reader, int channelId)
	{
		return false;
	}

	internal static void OnTransportData(ArraySegment<byte> data, int channelId)
	{
	}

	internal static void OnTransportDisconnected()
	{
	}

	private static void OnTransportError(TransportError error, string reason)
	{
	}

	private static void OnTransportException(Exception exception)
	{
	}

	public static void Send<T>(T message, int channelId = 0) where T : struct, NetworkMessage
	{
	}

	internal static void RegisterMessageHandlers(bool hostMode)
	{
	}

	public static void RegisterHandler<T>(Action<T> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void RegisterHandler<T>(Action<T, int> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void ReplaceHandler<T>(Action<T> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void ReplaceHandler<T>(Action<T, int> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static bool UnregisterHandler<T>() where T : struct, NetworkMessage
	{
		return false;
	}

	public static bool GetPrefab(uint assetId, out GameObject prefab)
	{
		prefab = null;
		return false;
	}

	private static void RegisterPrefabIdentity(NetworkIdentity prefab)
	{
	}

	public static void RegisterPrefab(GameObject prefab, uint newAssetId)
	{
	}

	public static void RegisterPrefab(GameObject prefab)
	{
	}

	public static void RegisterPrefab(GameObject prefab, uint newAssetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void RegisterPrefab(GameObject prefab, uint newAssetId, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void RegisterPrefab(GameObject prefab, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void UnregisterPrefab(GameObject prefab)
	{
	}

	public static void RegisterSpawnHandler(uint assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void RegisterSpawnHandler(uint assetId, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
	{
	}

	public static void UnregisterSpawnHandler(uint assetId)
	{
	}

	public static void ClearSpawners()
	{
	}

	internal static bool InvokeUnSpawnHandler(uint assetId, GameObject obj)
	{
		return false;
	}

	public static bool Ready()
	{
		return false;
	}

	internal static void InternalAddPlayer(NetworkIdentity identity)
	{
	}

	public static bool AddPlayer()
	{
		return false;
	}

	internal static void ApplySpawnPayload(NetworkIdentity identity, SpawnMessage message)
	{
	}

	internal static bool FindOrSpawnObject(SpawnMessage message, out NetworkIdentity identity)
	{
		identity = null;
		return false;
	}

	private static NetworkIdentity GetExistingObject(uint netid)
	{
		return null;
	}

	private static NetworkIdentity SpawnPrefab(SpawnMessage message)
	{
		return null;
	}

	private static NetworkIdentity SpawnSceneObject(ulong sceneId)
	{
		return null;
	}

	private static NetworkIdentity GetAndRemoveSceneObject(ulong sceneId)
	{
		return null;
	}

	public static void PrepareToSpawnSceneObjects()
	{
	}

	internal static void OnObjectSpawnStarted(ObjectSpawnStartedMessage _)
	{
	}

	internal static void OnObjectSpawnFinished(ObjectSpawnFinishedMessage _)
	{
	}

	private static void OnHostClientObjectHide(ObjectHideMessage message)
	{
	}

	internal static void OnHostClientSpawn(SpawnMessage message)
	{
	}

	private static void BootstrapIdentity(NetworkIdentity identity)
	{
	}

	private static void InitializeIdentityFlags(NetworkIdentity identity)
	{
	}

	private static void InvokeIdentityCallbacks(NetworkIdentity identity)
	{
	}

	private static void OnEntityStateMessage(EntityStateMessage message)
	{
	}

	private static void OnRPCMessage(RpcMessage message)
	{
	}

	private static void OnObjectHide(ObjectHideMessage message)
	{
	}

	internal static void OnObjectDestroy(ObjectDestroyMessage message)
	{
	}

	internal static void OnSpawn(SpawnMessage message)
	{
	}

	internal static void OnChangeOwner(ChangeOwnerMessage message)
	{
	}

	internal static void ChangeOwner(NetworkIdentity identity, ChangeOwnerMessage message)
	{
	}

	internal static void NetworkEarlyUpdate()
	{
	}

	internal static void NetworkLateUpdate()
	{
	}

	private static void Broadcast()
	{
	}

	private static void BroadcastToServer()
	{
	}

	public static void DestroyAllClientObjects()
	{
	}

	private static void DestroyObject(uint netId)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void Shutdown()
	{
	}

	public static void OnGUI()
	{
	}

	private static void InitTimeInterpolation()
	{
	}

	private static void OnTimeSnapshotMessage(TimeSnapshotMessage _)
	{
	}

	public static void OnTimeSnapshot(TimeSnapshot snap)
	{
	}

	private static void UpdateTimeInterpolation()
	{
	}
}
