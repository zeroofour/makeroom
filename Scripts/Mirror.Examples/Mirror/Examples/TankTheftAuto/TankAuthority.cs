using System;
using System.Runtime.InteropServices;
using Mirror.Examples.Common.Controllers.Tank;
using UnityEngine;

namespace Mirror.Examples.TankTheftAuto;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
public class TankAuthority : NetworkBehaviour
{
	[Header("Components")]
	public GameObject triggerUI;

	public TankTurretBase tankTurret;

	public GameObject tankTrigger;

	[SyncVar(hook = "OnIsControlledChanged")]
	public bool isControlled;

	public Action<bool, bool> _Mirror_SyncVarHookDelegate_isControlled;

	public bool NetworkisControlled
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

	private void OnIsControlledChanged(bool _, bool newValue)
	{
	}

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	[ClientCallback]
	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdTakeControl(NetworkConnectionToClient conn = null)
	{
	}

	[Command]
	private void CmdReleaseControl()
	{
	}

	public override void OnStartAuthority()
	{
	}

	public override void OnStopAuthority()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStopClient()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdTakeControl__NetworkConnectionToClient(NetworkConnectionToClient conn)
	{
	}

	protected static void InvokeUserCode_CmdTakeControl__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdReleaseControl()
	{
	}

	protected static void InvokeUserCode_CmdReleaseControl(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static TankAuthority()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
