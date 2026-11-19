using System;
using UnityEngine;

namespace Mirror;

public struct SpawnMessage : NetworkMessage
{
	public uint netId;

	public SpawnFlags spawnFlags;

	public ulong sceneId;

	public uint assetId;

	public Vector3 position;

	public Quaternion rotation;

	public Vector3 scale;

	public ArraySegment<byte> payload;

	public bool isOwner
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isLocalPlayer
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
