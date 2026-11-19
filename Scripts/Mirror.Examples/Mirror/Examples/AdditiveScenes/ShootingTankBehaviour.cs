using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.AdditiveScenes;

public class ShootingTankBehaviour : NetworkBehaviour
{
	[SyncVar]
	public Quaternion rotation;

	private NetworkAnimator networkAnimator;

	[Range(0f, 1f)]
	public float turnSpeed;

	public Quaternion Networkrotation
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

	[ServerCallback]
	private void Start()
	{
	}

	private void Update()
	{
	}

	[Server]
	private void ShootNearestPlayer()
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
