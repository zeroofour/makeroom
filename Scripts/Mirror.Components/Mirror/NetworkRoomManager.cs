using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror;

[AddComponentMenu("Network/Network Room Manager")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-room-manager")]
public class NetworkRoomManager : NetworkManager
{
	public struct PendingPlayer
	{
		public NetworkConnectionToClient conn;

		public GameObject roomPlayer;
	}

	[Tooltip("This flag controls whether the default UI is shown for the room")]
	[FormerlySerializedAs("m_ShowRoomGUI")]
	[Header("Room Settings")]
	[SerializeField]
	public bool showRoomGUI;

	[Tooltip("Minimum number of players to auto-start the game")]
	[SerializeField]
	[FormerlySerializedAs("m_MinPlayers")]
	public int minPlayers;

	[Tooltip("Prefab to use for the Room Player")]
	[SerializeField]
	[FormerlySerializedAs("m_RoomPlayerPrefab")]
	public NetworkRoomPlayer roomPlayerPrefab;

	[Scene]
	public string RoomScene;

	[Scene]
	public string GameplayScene;

	[FormerlySerializedAs("m_PendingPlayers")]
	public HashSet<PendingPlayer> pendingPlayers;

	[ReadOnly]
	[Header("Diagnostics")]
	[Tooltip("Diagnostic flag indicating all players are ready to play")]
	[FormerlySerializedAs("allPlayersReady")]
	[SerializeField]
	private bool _allPlayersReady;

	[ReadOnly]
	[Tooltip("List of Room Player objects")]
	public HashSet<NetworkRoomPlayer> roomSlots;

	public int clientIndex;

	public bool allPlayersReady
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void OnValidate()
	{
	}

	private void SceneLoadedForPlayer(NetworkConnectionToClient conn, GameObject roomPlayer)
	{
	}

	internal void CallOnClientEnterRoom()
	{
	}

	internal void CallOnClientExitRoom()
	{
	}

	public void CheckReadyToBegin()
	{
	}

	public override void OnServerConnect(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerReady(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	[Server]
	public void RecalculateRoomPlayerIndices()
	{
	}

	public override void ServerChangeScene(string newSceneName)
	{
	}

	public override void OnServerSceneChanged(string sceneName)
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartHost()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStopHost()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnClientConnect()
	{
	}

	public override void OnClientDisconnect()
	{
	}

	public override void OnStopClient()
	{
	}

	public override void OnClientSceneChanged()
	{
	}

	public virtual void OnRoomStartHost()
	{
	}

	public virtual void OnRoomStopHost()
	{
	}

	public virtual void OnRoomStartServer()
	{
	}

	public virtual void OnRoomStopServer()
	{
	}

	public virtual void OnRoomServerConnect(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnRoomServerDisconnect(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnRoomServerSceneChanged(string sceneName)
	{
	}

	public virtual GameObject OnRoomServerCreateRoomPlayer(NetworkConnectionToClient conn)
	{
		return null;
	}

	public virtual GameObject OnRoomServerCreateGamePlayer(NetworkConnectionToClient conn, GameObject roomPlayer)
	{
		return null;
	}

	public virtual void OnRoomServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	public virtual bool OnRoomServerSceneLoadedForPlayer(NetworkConnectionToClient conn, GameObject roomPlayer, GameObject gamePlayer)
	{
		return false;
	}

	public virtual void ReadyStatusChanged()
	{
	}

	public virtual void OnRoomServerPlayersReady()
	{
	}

	public virtual void OnRoomServerPlayersNotReady()
	{
	}

	public virtual void OnRoomClientEnter()
	{
	}

	public virtual void OnRoomClientExit()
	{
	}

	public virtual void OnRoomClientConnect()
	{
	}

	public virtual void OnRoomClientDisconnect()
	{
	}

	public virtual void OnRoomStartClient()
	{
	}

	public virtual void OnRoomStopClient()
	{
	}

	public virtual void OnRoomClientSceneChanged()
	{
	}

	public virtual void OnGUI()
	{
	}
}
