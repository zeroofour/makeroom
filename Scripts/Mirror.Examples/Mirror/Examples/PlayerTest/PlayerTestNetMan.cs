using System;

namespace Mirror.Examples.PlayerTest;

public class PlayerTestNetMan : NetworkManager
{
	public new static PlayerTestNetMan singleton => null;

	public override void Awake()
	{
	}

	public override void OnValidate()
	{
	}

	public override void Start()
	{
	}

	public override void LateUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void ConfigureHeadlessFrameRate()
	{
	}

	public override void OnApplicationQuit()
	{
	}

	public override void ServerChangeScene(string newSceneName)
	{
	}

	public override void OnServerChangeScene(string newSceneName)
	{
	}

	public override void OnServerSceneChanged(string sceneName)
	{
	}

	public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
	{
	}

	public override void OnClientSceneChanged()
	{
	}

	public override void OnServerConnect(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerReady(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
	{
	}

	public override void OnServerTransportException(NetworkConnectionToClient conn, Exception exception)
	{
	}

	public override void OnClientConnect()
	{
	}

	public override void OnClientDisconnect()
	{
	}

	public override void OnClientNotReady()
	{
	}

	public override void OnClientError(TransportError transportError, string message)
	{
	}

	public override void OnClientTransportException(Exception exception)
	{
	}

	public override void OnStartHost()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStopHost()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStopClient()
	{
	}
}
