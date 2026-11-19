using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.Basic;

[AddComponentMenu(null)]
public class Player : NetworkBehaviour
{
	[CompilerGenerated]
	private Action<byte> m_OnPlayerNumberChanged;

	[CompilerGenerated]
	private Action<Color32> m_OnPlayerColorChanged;

	[CompilerGenerated]
	private Action<ushort> m_OnPlayerDataChanged;

	private static readonly List<Player> playersList;

	[Header("Player UI")]
	public GameObject playerUIPrefab;

	private GameObject playerUIObject;

	private PlayerUI playerUI;

	[Header("SyncVars")]
	[SyncVar(hook = "PlayerNumberChanged")]
	public byte playerNumber;

	[SyncVar(hook = "PlayerColorChanged")]
	public Color32 playerColor;

	[SyncVar(hook = "PlayerDataChanged")]
	public ushort playerData;

	public Action<byte, byte> _Mirror_SyncVarHookDelegate_playerNumber;

	public Action<Color32, Color32> _Mirror_SyncVarHookDelegate_playerColor;

	public Action<ushort, ushort> _Mirror_SyncVarHookDelegate_playerData;

	public byte NetworkplayerNumber
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

	public Color32 NetworkplayerColor
	{
		get
		{
			return default;
		}
		[param: In]
		set
		{
		}
	}

	public ushort NetworkplayerData
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

	public event Action<byte> OnPlayerNumberChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Color32> OnPlayerColorChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ushort> OnPlayerDataChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void PlayerNumberChanged(byte _, byte newPlayerNumber)
	{
	}

	private void PlayerColorChanged(Color32 _, Color32 newPlayerColor)
	{
	}

	private void PlayerDataChanged(ushort _, ushort newPlayerData)
	{
	}

	public override void OnStartServer()
	{
	}

	[ServerCallback]
	internal static void ResetPlayerNumbers()
	{
	}

	[ServerCallback]
	private void UpdateData()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	public override void OnStopLocalPlayer()
	{
	}

	public override void OnStopClient()
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
