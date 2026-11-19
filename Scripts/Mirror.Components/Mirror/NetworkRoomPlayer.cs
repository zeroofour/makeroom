using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-room-player")]
[DisallowMultipleComponent]
[AddComponentMenu("Network/Network Room Player")]
public class NetworkRoomPlayer : NetworkBehaviour
{
	[Tooltip("This flag controls whether the default UI is shown for the room player")]
	public bool showRoomGUI;

	[ReadOnly]
	[Tooltip("Diagnostic flag indicating whether this player is ready for the game to begin")]
	[SyncVar(hook = "ReadyStateChanged")]
	[Header("Diagnostics")]
	public bool readyToBegin;

	[SyncVar(hook = "IndexChanged")]
	[ReadOnly]
	[Tooltip("Diagnostic index of the player, e.g. Player1, Player2, etc.")]
	public int index;

	public Action<bool, bool> _Mirror_SyncVarHookDelegate_readyToBegin;

	public Action<int, int> _Mirror_SyncVarHookDelegate_index;

	public bool NetworkreadyToBegin
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

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

	public virtual void Start()
	{
	}

	public virtual void OnDisable()
	{
	}

	[Command]
	public void CmdChangeReadyState(bool readyState)
	{
	}

	public virtual void IndexChanged(int oldIndex, int newIndex)
	{
	}

	public virtual void ReadyStateChanged(bool oldReadyState, bool newReadyState)
	{
	}

	public virtual void OnClientEnterRoom()
	{
	}

	public virtual void OnClientExitRoom()
	{
	}

	public virtual void OnGUI()
	{
	}

	private void DrawPlayerReadyState()
	{
	}

	private void DrawPlayerReadyButton()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdChangeReadyState__Boolean(bool readyState)
	{
	}

	protected static void InvokeUserCode_CmdChangeReadyState__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkRoomPlayer()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
