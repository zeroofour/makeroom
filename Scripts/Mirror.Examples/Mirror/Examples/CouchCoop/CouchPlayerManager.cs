using UnityEngine;

namespace Mirror.Examples.CouchCoop;

public class CouchPlayerManager : NetworkBehaviour
{
	public CanvasScript canvasScript;

	public GameObject[] playerPrefabs;

	public int totalCouchPlayers;

	public KeyCode[] playerKeyJump;

	public KeyCode[] playerKeyLeft;

	public KeyCode[] playerKeyRight;

	private readonly SyncList<GameObject> couchPlayersList;

	public override void OnStartAuthority()
	{
	}

	[Command]
	public void CmdAddPlayer()
	{
	}

	[Command]
	public void CmdRemovePlayer()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdAddPlayer()
	{
	}

	protected static void InvokeUserCode_CmdAddPlayer(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdRemovePlayer()
	{
	}

	protected static void InvokeUserCode_CmdRemovePlayer(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static CouchPlayerManager()
	{
	}
}
