using System.Runtime.InteropServices;

namespace Mirror.Examples.Chat;

public class Player : NetworkBehaviour
{
	[SyncVar]
	public string playerName;

	public string NetworkplayerName
	{
		get
		{
			return null;
		}
		[param: In]
		set
		{
		}
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
