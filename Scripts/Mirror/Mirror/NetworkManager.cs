using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Mirror;

[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Manager")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-manager")]
public class NetworkManager : MonoBehaviour
{
	[Tooltip("Should the Network Manager object be persisted through scene changes?")]
	[Header("Configuration")]
	[FormerlySerializedAs("m_DontDestroyOnLoad")]
	public bool dontDestroyOnLoad;

	[FormerlySerializedAs("m_RunInBackground")]
	[Tooltip("Multiplayer games should always run in the background so the network doesn't time out.")]
	public bool runInBackground;

	[Tooltip("Choose whether Server or Client should auto-start in headless builds")]
	[Header("Auto-Start Options")]
	public HeadlessStartOptions headlessStartMode;

	[Tooltip("Headless Start Mode in Editor\nwhen enabled, headless start mode will be used in editor as well.")]
	public bool editorAutoStart;

	[Tooltip("Server / Client send rate per second.\nUse 60-100Hz for fast paced games like Counter-Strike to minimize latency.\nUse around 30Hz for games like WoW to minimize computations.\nUse around 1-10Hz for slow paced games like EVE.")]
	[FormerlySerializedAs("serverTickRate")]
	public int sendRate;

	[Header("Scene Management")]
	[Scene]
	[FormerlySerializedAs("m_OfflineScene")]
	[Tooltip("Scene that Mirror will switch to when the client or server is stopped")]
	public string offlineScene;

	[Scene]
	[FormerlySerializedAs("m_OnlineScene")]
	[Tooltip("Scene that Mirror will switch to when the server is started. Clients will recieve a Scene Message to load the server's current scene when they connect.")]
	public string onlineScene;

	[Range(0f, 60f)]
	[Tooltip("Optional delay that can be used after disconnecting to show a 'Connection lost...' message or similar before loading the offline scene, which may take a long time in big projects.")]
	public float offlineSceneLoadDelay;

	[Header("Network Info")]
	[Tooltip("Transport component attached to this object that server and client will use to connect")]
	public Transport transport;

	[FormerlySerializedAs("m_NetworkAddress")]
	[Tooltip("Network Address where the client should connect to the server. Server does not use this for anything.")]
	public string networkAddress;

	[FormerlySerializedAs("m_MaxConnections")]
	[Tooltip("Maximum number of concurrent connections.")]
	public int maxConnections;

	[Tooltip("When enabled, the server automatically disconnects inactive connections after the configured timeout.")]
	public bool disconnectInactiveConnections;

	[Tooltip("Timeout in seconds for server to automatically disconnect inactive connections if 'disconnectInactiveConnections' is enabled.")]
	public float disconnectInactiveTimeout;

	[Header("Authentication")]
	[Tooltip("Authentication component attached to this object")]
	public NetworkAuthenticator authenticator;

	[Header("Player Object")]
	[FormerlySerializedAs("m_PlayerPrefab")]
	[Tooltip("Prefab of the player object. Prefab must have a Network Identity component. May be an empty game object or a full avatar.")]
	public GameObject playerPrefab;

	[Tooltip("Should Mirror automatically spawn the player after scene change?")]
	[FormerlySerializedAs("m_AutoCreatePlayer")]
	public bool autoCreatePlayer;

	[Tooltip("Round Robin or Random order of Start Position selection")]
	[FormerlySerializedAs("m_PlayerSpawnMethod")]
	public PlayerSpawnMethod playerSpawnMethod;

	[FormerlySerializedAs("m_SpawnPrefabs")]
	[HideInInspector]
	public List<GameObject> spawnPrefabs;

	public static List<Transform> startPositions;

	public static int startPositionIndex;

	[Tooltip("For security, it is recommended to disconnect a player if a networked action triggers an exception\nThis could prevent components being accessed in an undefined state, which may be an attack vector for exploits.\nHowever, some games may want to allow exceptions in order to not interrupt the player's experience.")]
	[Header("Security")]
	public bool exceptionsDisconnect;

	[Header("Snapshot Interpolation")]
	public SnapshotInterpolationSettings snapshotSettings;

	[Header("Connection Quality")]
	[Tooltip("Method to use for connection quality evaluation.\nSimple: based on rtt and jitter.\nPragmatic: based on snapshot interpolation adjustment.")]
	public ConnectionQualityMethod evaluationMethod;

	[Range(0f, 60f)]
	[Tooltip("Interval in seconds to evaluate connection quality.\nSet to 0 to disable connection quality evaluation.")]
	[FormerlySerializedAs("connectionQualityInterval")]
	public float evaluationInterval;

	[Header("Interpolation UI - Requires Editor / Dev Build")]
	public bool timeInterpolationGui;

	internal static NetworkConnection clientReadyConnection;

	protected bool clientLoadedScene;

	private bool finishStartHostPending;

	public static AsyncOperation loadingSceneAsync;

	private SceneOperation clientSceneOperation;

	public static NetworkManager singleton { get; internal set; }

	public int numPlayers => 0;

	public bool isNetworkActive => false;

	public NetworkManagerMode mode { get; private set; }

	public static string networkSceneName { get; protected set; }

	public virtual void OnValidate()
	{
	}

	public virtual void Reset()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void LateUpdate()
	{
	}

	private bool IsServerOnlineSceneChangeNeeded()
	{
		return false;
	}

	private void ApplyConfiguration()
	{
	}

	private void SetupServer()
	{
	}

	public void StartServer()
	{
	}

	private void SetupClient()
	{
	}

	public void StartClient()
	{
	}

	public void StartClient(Uri uri)
	{
	}

	public void StartHost()
	{
	}

	private void FinishStartHost()
	{
	}

	public void StopHost()
	{
	}

	public void StopServer()
	{
	}

	public void StopClient()
	{
	}

	public virtual void OnApplicationQuit()
	{
	}

	public virtual void ConfigureHeadlessFrameRate()
	{
	}

	private bool InitializeSingleton()
	{
		return false;
	}

	private void RegisterServerMessages()
	{
	}

	private void RegisterClientMessages()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void ResetStatics()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void ServerChangeScene(string newSceneName)
	{
	}

	internal void ClientChangeScene(string newSceneName, SceneOperation sceneOperation = SceneOperation.Normal, bool customHandling = false)
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void UpdateScene()
	{
	}

	protected void FinishLoadScene()
	{
	}

	private void FinishLoadSceneHost()
	{
	}

	private void FinishLoadSceneServerOnly()
	{
	}

	private void FinishLoadSceneClientOnly()
	{
	}

	public static void RegisterStartPosition(Transform start)
	{
	}

	public static void UnRegisterStartPosition(Transform start)
	{
	}

	public virtual Transform GetStartPosition()
	{
		return null;
	}

	private void OnServerConnectInternal(NetworkConnectionToClient conn)
	{
	}

	private void OnServerAuthenticated(NetworkConnectionToClient conn)
	{
	}

	private void OnServerReadyMessageInternal(NetworkConnectionToClient conn, ReadyMessage msg)
	{
	}

	private void OnServerAddPlayerInternal(NetworkConnectionToClient conn, AddPlayerMessage msg)
	{
	}

	private void OnClientConnectInternal()
	{
	}

	private void OnClientAuthenticated()
	{
	}

	private void OnClientDisconnectInternal()
	{
	}

	private void ClientChangeOfflineScene()
	{
	}

	private void OnClientNotReadyMessageInternal(NotReadyMessage msg)
	{
	}

	private void OnClientSceneInternal(SceneMessage msg)
	{
	}

	public virtual void OnServerConnect(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnServerReady(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnServerError(NetworkConnectionToClient conn, TransportError error, string reason)
	{
	}

	public virtual void OnServerTransportException(NetworkConnectionToClient conn, Exception exception)
	{
	}

	public virtual void OnServerChangeScene(string newSceneName)
	{
	}

	public virtual void OnServerSceneChanged(string sceneName)
	{
	}

	public virtual void OnClientConnect()
	{
	}

	public virtual void OnClientDisconnect()
	{
	}

	public virtual void OnClientError(TransportError error, string reason)
	{
	}

	public virtual void OnClientTransportException(Exception exception)
	{
	}

	public virtual void OnClientNotReady()
	{
	}

	public virtual void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
	{
	}

	public virtual void OnClientSceneChanged()
	{
	}

	public virtual void OnStartHost()
	{
	}

	public virtual void OnStartServer()
	{
	}

	public virtual void OnStartClient()
	{
	}

	public virtual void OnStopServer()
	{
	}

	public virtual void OnStopClient()
	{
	}

	public virtual void OnStopHost()
	{
	}
}
