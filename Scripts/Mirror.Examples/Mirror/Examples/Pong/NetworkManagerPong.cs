using UnityEngine;

namespace Mirror.Examples.Pong;

[AddComponentMenu(null)]
public class NetworkManagerPong : NetworkManager
{
	public Transform leftRacketSpawn;

	public Transform rightRacketSpawn;

	private GameObject ball;

	public override void OnServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}
}
