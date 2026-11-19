using UnityEngine;

namespace Mirror.Examples.TankTheftAuto;

[AddComponentMenu(null)]
public class TankTheftAutoNetMan : NetworkManager
{
	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
	}
}
