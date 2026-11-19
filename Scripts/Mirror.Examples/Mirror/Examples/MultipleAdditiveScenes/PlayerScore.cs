using System.Runtime.InteropServices;

namespace Mirror.Examples.MultipleAdditiveScenes;

public class PlayerScore : NetworkBehaviour
{
	[SyncVar]
	public int playerNumber;

	[SyncVar]
	public int scoreIndex;

	[SyncVar]
	public int matchIndex;

	[SyncVar]
	public uint score;

	public int clientMatchIndex;

	public int NetworkplayerNumber
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public int NetworkscoreIndex
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public int NetworkmatchIndex
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public uint Networkscore
	{
		get
		{
			return 0u;
		}
		[param: In]
		set
		{
		}
	}

	private void OnGUI()
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
