using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;

namespace Mirror.Examples.Tanks;

public class Tank : NetworkBehaviour
{
	[Header("Components")]
	public NavMeshAgent agent;

	public Animator animator;

	public TextMesh healthBar;

	public Transform turret;

	[Header("Movement")]
	public float rotationSpeed;

	[Header("Firing")]
	public KeyCode shootKey;

	public GameObject projectilePrefab;

	public Transform projectileMount;

	[SyncVar]
	[Header("Stats")]
	public int health;

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

	public override void OnStartClient()
	{
	}

	public override void OnStartServer()
	{
	}

	private void Update()
	{
	}

	[Command]
	private void CmdFire()
	{
	}

	[ClientRpc]
	private void RpcOnFire()
	{
	}

	private void RotateTurret()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdFire()
	{
	}

	protected static void InvokeUserCode_CmdFire(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcOnFire()
	{
	}

	protected static void InvokeUserCode_RpcOnFire(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static Tank()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
