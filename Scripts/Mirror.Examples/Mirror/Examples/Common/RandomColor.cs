using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.Common;

[AddComponentMenu(null)]
public class RandomColor : NetworkBehaviour
{
	private Material cachedMaterial;

	[SyncVar(hook = "SetColor")]
	public Color32 color;

	public Action<Color32, Color32> _Mirror_SyncVarHookDelegate_color;

	public Color32 Networkcolor
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

	private void SetColor(Color32 _, Color32 newColor)
	{
	}

	public override void OnStartServer()
	{
	}

	private void OnDestroy()
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
