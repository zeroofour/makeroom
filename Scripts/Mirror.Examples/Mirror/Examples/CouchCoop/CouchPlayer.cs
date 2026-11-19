using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.CouchCoop;

public class CouchPlayer : NetworkBehaviour
{
	public Rigidbody rb;

	public float movementSpeed;

	public float jumpSpeed;

	private float movementVelocity;

	private bool isGrounded;

	public CouchPlayerManager couchPlayerManager;

	private KeyCode jumpKey;

	private KeyCode leftKey;

	private KeyCode rightKey;

	[SyncVar(hook = "OnNumberChangedHook")]
	public int playerNumber;

	public Text textPlayerNumber;

	public static readonly List<GameObject> playersList;

	public Action<int, int> _Mirror_SyncVarHookDelegate_playerNumber;

	public int NetworkplayerNumber
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

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public override void OnStartAuthority()
	{
	}

	private void Update()
	{
	}

	[ClientCallback]
	private void OnCollisionExit(Collision col)
	{
	}

	[ClientCallback]
	private void OnCollisionStay(Collision col)
	{
	}

	private void OnNumberChangedHook(int _old, int _new)
	{
	}

	public void SetPlayerUI()
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
