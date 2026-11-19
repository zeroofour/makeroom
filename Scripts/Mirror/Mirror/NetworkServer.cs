using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public static class NetworkServer
{
	private static bool initialized;

	public static int maxConnections;

	public static int tickRate;

	private static double lastSendTime;

	public static Dictionary<int, NetworkConnectionToClient> connections;

	internal static Dictionary<ushort, NetworkMessageDelegate> handlers;

	public static readonly Dictionary<uint, NetworkIdentity> spawned;

	public static bool listen;

	public static bool isLoadingScene;

	public static InterestManagementBase aoi;

	public static bool exceptionsDisconnect;

	public static bool disconnectInactiveConnections;

	public static float disconnectInactiveTimeout;

	public static Action<NetworkConnectionToClient> OnConnectedEvent;

	public static Action<NetworkConnectionToClient> OnDisconnectedEvent;

	public static Action<NetworkConnectionToClient, TransportError, string> OnErrorEvent;

	public static Action<NetworkConnectionToClient, Exception> OnTransportExceptionEvent;

	public static int actualTickRate;

	private static double actualTickRateStart;

	private static int actualTickRateCounter;

	public static TimeSample earlyUpdateDuration;

	public static TimeSample lateUpdateDuration;

	public static TimeSample fullUpdateDuration;

	internal static readonly List<NetworkConnectionToClient> connectionsCopy;

	public static float tickInterval => 0f;

	public static int sendRate => 0;

	public static float sendInterval => 0f;

	public static LocalConnectionToClient localConnection { get; private set; }

	[Obsolete("NetworkServer.dontListen was replaced with NetworkServer.listen. The new value is the opposite, and avoids double negatives like 'dontListen=false'")]
	public static bool dontListen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool active { get; internal set; }

	public static bool activeHost => false;

	public static void Listen(int maxConns)
	{
	}

	private static void Initialize()
	{
	}

	private static void AddTransportHandlers()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void Shutdown()
	{
	}

	private static void RemoveTransportHandlers()
	{
	}

	private static void CleanupSpawned()
	{
	}

	internal static void RegisterMessageHandlers()
	{
	}

	private static void OnClientReadyMessage(NetworkConnectionToClient conn, ReadyMessage msg)
	{
	}

	private static void OnCommandMessage(NetworkConnectionToClient conn, CommandMessage msg, int channelId)
	{
	}

	private static void OnEntityStateMessage(NetworkConnectionToClient connection, EntityStateMessage message)
	{
	}

	private static void OnTimeSnapshotMessage(NetworkConnectionToClient connection, TimeSnapshotMessage _)
	{
	}

	public static bool AddConnection(NetworkConnectionToClient conn)
	{
		return false;
	}

	public static bool RemoveConnection(int connectionId)
	{
		return false;
	}

	internal static void SetLocalConnection(LocalConnectionToClient conn)
	{
	}

	internal static void RemoveLocalConnection()
	{
	}

	public static bool HasExternalConnections()
	{
		return false;
	}

	public static void SendToAll<T>(T message, int channelId = 0, bool sendToReadyOnly = false) where T : struct, NetworkMessage
	{
	}

	public static void SendToReady<T>(T message, int channelId = 0) where T : struct, NetworkMessage
	{
	}

	private static void SendToObservers<T>(NetworkIdentity identity, T message, int channelId = 0) where T : struct, NetworkMessage
	{
	}

	public static void SendToReadyObservers<T>(NetworkIdentity identity, T message, bool includeOwner = true, int channelId = 0) where T : struct, NetworkMessage
	{
	}

	public static void SendToReadyObservers<T>(NetworkIdentity identity, T message, int channelId) where T : struct, NetworkMessage
	{
	}

	private static void OnTransportConnected(int connectionId)
	{
	}

	private static void OnTransportConnectedWithAddress(int connectionId, string clientAddress)
	{
	}

	private static bool IsConnectionAllowed(int connectionId, string address)
	{
		return false;
	}

	internal static void OnConnected(NetworkConnectionToClient conn)
	{
	}

	private static bool UnpackAndInvoke(NetworkConnectionToClient connection, NetworkReader reader, int channelId)
	{
		return false;
	}

	internal static void OnTransportData(int connectionId, ArraySegment<byte> data, int channelId)
	{
	}

	internal static void OnTransportDisconnected(int connectionId)
	{
	}

	private static void OnTransportError(int connectionId, TransportError error, string reason)
	{
	}

	private static void OnTransportException(int connectionId, Exception exception)
	{
	}

	public static void DestroyPlayerForConnection(NetworkConnectionToClient conn)
	{
	}

	public static void RegisterHandler<T>(Action<NetworkConnectionToClient, T> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void RegisterHandler<T>(Action<NetworkConnectionToClient, T, int> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void ReplaceHandler<T>(Action<T> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void ReplaceHandler<T>(Action<NetworkConnectionToClient, T> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void ReplaceHandler<T>(Action<NetworkConnectionToClient, T, int> handler, bool requireAuthentication = true) where T : struct, NetworkMessage
	{
	}

	public static void UnregisterHandler<T>() where T : struct, NetworkMessage
	{
	}

	public static void ClearHandlers()
	{
	}

	internal static bool GetNetworkIdentity(GameObject go, out NetworkIdentity identity)
	{
		identity = null;
		return false;
	}

	public static void DisconnectAll()
	{
	}

	public static bool AddPlayerForConnection(NetworkConnectionToClient conn, GameObject player, uint assetId)
	{
		return false;
	}

	public static bool AddPlayerForConnection(NetworkConnectionToClient conn, GameObject player)
	{
		return false;
	}

	[Obsolete("Use ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, uint assetId, ReplacePlayerOptions replacePlayerOptions) instead")]
	public static bool ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, uint assetId, bool keepAuthority = false)
	{
		return false;
	}

	[Obsolete("Use ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, ReplacePlayerOptions replacePlayerOptions) instead")]
	public static bool ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, bool keepAuthority = false)
	{
		return false;
	}

	public static bool ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, uint assetId, ReplacePlayerOptions replacePlayerOptions)
	{
		return false;
	}

	public static bool ReplacePlayerForConnection(NetworkConnectionToClient conn, GameObject player, ReplacePlayerOptions replacePlayerOptions)
	{
		return false;
	}

	[Obsolete("Use RemovePlayerForConnection(NetworkConnectionToClient conn, RemovePlayerOptions removeOptions) instead")]
	public static void RemovePlayerForConnection(NetworkConnectionToClient conn, bool destroyServerObject)
	{
	}

	public static void RemovePlayerForConnection(NetworkConnectionToClient conn, RemovePlayerOptions removeOptions = RemovePlayerOptions.KeepActive)
	{
	}

	public static void SetClientReady(NetworkConnectionToClient conn)
	{
	}

	private static void SpawnObserversForConnection(NetworkConnectionToClient conn)
	{
	}

	public static void SetClientNotReady(NetworkConnectionToClient conn)
	{
	}

	public static void SetAllClientsNotReady()
	{
	}

	internal static void ShowForConnection(NetworkIdentity identity, NetworkConnectionToClient conn)
	{
	}

	internal static void HideForConnection(NetworkIdentity identity, NetworkConnectionToClient conn)
	{
	}

	internal static void SendSpawnMessage(NetworkIdentity identity, NetworkConnectionToClient conn)
	{
	}

	private static ArraySegment<byte> CreateSpawnMessagePayload(bool isOwner, NetworkIdentity identity, NetworkWriterPooled ownerWriter, NetworkWriterPooled observersWriter)
	{
		return default;
	}

	internal static void SendChangeOwnerMessage(NetworkIdentity identity, NetworkConnectionToClient conn)
	{
	}

	private static bool ValidParent(NetworkIdentity identity)
	{
		return false;
	}

	public static bool SpawnObjects()
	{
		return false;
	}

	public static void Spawn(GameObject obj, GameObject ownerPlayer)
	{
	}

	private static void Respawn(NetworkIdentity identity)
	{
	}

	public static void Spawn(GameObject obj, NetworkConnectionToClient ownerConnection = null)
	{
	}

	public static void Spawn(GameObject obj, uint assetId, NetworkConnectionToClient ownerConnection = null)
	{
	}

	private static void SpawnObject(GameObject obj, NetworkConnectionToClient ownerConnection)
	{
	}

	private static void UnSpawnInternal(GameObject obj, bool resetState)
	{
	}

	public static void UnSpawn(GameObject obj)
	{
	}

	public static void Destroy(GameObject obj)
	{
	}

	private static void RebuildObserversDefault(NetworkIdentity identity, bool initialize)
	{
	}

	internal static void AddAllReadyServerConnectionsToObservers(NetworkIdentity identity)
	{
	}

	public static void RebuildObservers(NetworkIdentity identity, bool initialize)
	{
	}

	private static NetworkWriter SerializeForConnection(NetworkIdentity identity, NetworkConnectionToClient connection)
	{
		return null;
	}

	private static void BroadcastToConnection(NetworkConnectionToClient connection)
	{
	}

	private static bool DisconnectIfInactive(NetworkConnectionToClient connection)
	{
		return false;
	}

	private static void Broadcast()
	{
	}

	internal static void NetworkEarlyUpdate()
	{
	}

	internal static void NetworkLateUpdate()
	{
	}
}
