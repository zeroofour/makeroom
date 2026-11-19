using UnityEngine;

namespace Mirror.Examples.Chat;

[AddComponentMenu(null)]
public class ChatNetworkManager : NetworkManager
{
	public void SetHostname(string hostname)
	{
	}

	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}

	public override void OnClientDisconnect()
	{
	}
}
