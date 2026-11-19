using UnityEngine;

namespace Mirror.Examples.NetworkRoom;

[AddComponentMenu(null)]
public class NetworkRoomManagerExt : NetworkRoomManager
{
	[Tooltip("Reward Prefab for the Spawner")]
	[Header("Spawner Setup")]
	public GameObject rewardPrefab;

	public byte poolSize;

	private bool showStartButton;

	public new static NetworkRoomManagerExt singleton => null;

	public override void OnRoomServerSceneChanged(string sceneName)
	{
	}

	public override void OnRoomClientSceneChanged()
	{
	}

	public override bool OnRoomServerSceneLoadedForPlayer(NetworkConnectionToClient conn, GameObject roomPlayer, GameObject gamePlayer)
	{
		return false;
	}

	public override void OnRoomStopClient()
	{
	}

	public override void OnRoomStopServer()
	{
	}

	public override void OnRoomServerPlayersReady()
	{
	}

	public override void OnGUI()
	{
	}
}
