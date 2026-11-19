using UnityEngine;

namespace Mirror.Examples.Basic;

[AddComponentMenu(null)]
public class BasicNetManager : NetworkManager
{
	public override void OnServerAddPlayer(NetworkConnectionToClient conn)
	{
	}

	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}
}
