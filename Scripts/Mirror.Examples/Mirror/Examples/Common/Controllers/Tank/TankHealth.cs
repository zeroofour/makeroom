using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[DisallowMultipleComponent]
[AddComponentMenu(null)]
public class TankHealth : NetworkBehaviour
{
	[Header("Components")]
	public TextMesh healthBar;

	[Header("Stats")]
	public byte maxHealth;

	[SyncVar(hook = "OnHealthChanged")]
	public byte health;

	[Header("Respawn")]
	public bool respawn;

	public byte respawnTime;

	public Action<byte, byte> _Mirror_SyncVarHookDelegate_health;

	public byte Networkhealth
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

	private void OnHealthChanged(byte oldHealth, byte newHealth)
	{
	}

	protected override void OnValidate()
	{
	}

	public void Reset()
	{
	}

	public override void OnStartServer()
	{
	}

	[ServerCallback]
	public void TakeDamage(byte damage)
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
