using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.CouchCoop;

public class MovingPlatform : NetworkBehaviour
{
	public Transform endTarget;

	public float moveSpeed;

	[SyncVar]
	public bool moveObj;

	public bool moveStopsUponExit;

	public bool moveStartsUponCollision;

	private Vector3 startPosition;

	private Vector3 endPosition;

	public bool NetworkmoveObj
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

	private void Awake()
	{
	}

	private void Update()
	{
	}

	[ClientRpc]
	private void RpcResyncPosition(byte _value)
	{
	}

	[ServerCallback]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[ServerCallback]
	private void OnCollisionExit(Collision collision)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_RpcResyncPosition__Byte(byte _value)
	{
	}

	protected static void InvokeUserCode_RpcResyncPosition__Byte(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static MovingPlatform()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
