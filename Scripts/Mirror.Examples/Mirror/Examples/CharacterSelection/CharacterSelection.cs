using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.CharacterSelection;

public class CharacterSelection : NetworkBehaviour
{
	public Transform floatingInfo;

	[SyncVar]
	public int characterNumber;

	public TextMesh textMeshName;

	[SyncVar(hook = "HookSetName")]
	public string playerName;

	[SyncVar(hook = "HookSetColor")]
	public Color characterColour;

	private Material cachedMaterial;

	public MeshRenderer[] characterRenderers;

	public Action<string, string> _Mirror_SyncVarHookDelegate_playerName;

	public Action<Color, Color> _Mirror_SyncVarHookDelegate_characterColour;

	public int NetworkcharacterNumber
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

	public Color NetworkcharacterColour
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

	private void HookSetName(string _old, string _new)
	{
	}

	private void HookSetColor(Color _old, Color _new)
	{
	}

	public void AssignColours()
	{
	}

	private void OnDestroy()
	{
	}

	public void AssignName()
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
