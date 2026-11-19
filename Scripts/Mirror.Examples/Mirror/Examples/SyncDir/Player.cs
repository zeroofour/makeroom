using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.SyncDir;

public class Player : NetworkBehaviour
{
	public TextMesh textMesh;

	public Color localColor;

	[SyncVar]
	public int health;

	private readonly SyncList<int> list;

	public int Networkhealth
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

	public override void OnStartLocalPlayer()
	{
	}

	private void Update()
	{
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
