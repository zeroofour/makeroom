using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.NetworkRoom;

[AddComponentMenu(null)]
public class PlayerScore : NetworkBehaviour
{
	[SyncVar]
	public int index;

	[SyncVar]
	public uint score;

	public int Networkindex
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
