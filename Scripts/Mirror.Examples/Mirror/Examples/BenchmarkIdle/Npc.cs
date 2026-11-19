using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.BenchmarkIdle;

public class Npc : NetworkBehaviour
{
	public Renderer rend;

	[SyncVar]
	private ulong value;

	[Range(0f, 1f)]
	[Tooltip("Probability that this object just sleeps the whole time without ever getting dirty. (Npcs, Item drops, etc.)")]
	public float sleepingProbability;

	private bool sleeping;

	[Header("Colors")]
	public Color activeColor;

	public Color sleepingColor;

	public ulong Networkvalue
	{
		get
		{
			return 0uL;
		}
		[param: In]
		set
		{
		}
	}

	public override void OnStartServer()
	{
	}

	[ServerCallback]
	private void Update()
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
