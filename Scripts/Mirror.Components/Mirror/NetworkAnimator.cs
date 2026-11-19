using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror;

[AddComponentMenu("Network/Network Animator")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-animator")]
public class NetworkAnimator : NetworkBehaviour
{
	[Header("Authority")]
	[Tooltip("Set to true if animations come from owner client,  set to false if animations always come from server")]
	public bool clientAuthority;

	[FormerlySerializedAs("m_Animator")]
	[Header("Animator")]
	[Tooltip("Animator that will have parameters synchronized")]
	public Animator animator;

	[SyncVar(hook = "OnAnimatorSpeedChanged")]
	private float animatorSpeed;

	private float previousSpeed;

	private int[] lastIntParameters;

	private float[] lastFloatParameters;

	private bool[] lastBoolParameters;

	private AnimatorControllerParameter[] parameters;

	private int[] animationHash;

	private int[] transitionHash;

	private float[] layerWeight;

	private double nextSendTime;

	public Action<float, float> _Mirror_SyncVarHookDelegate_animatorSpeed;

	private bool SendMessagesAllowed => false;

	public float NetworkanimatorSpeed
	{
		get
		{
			return 0f;
		}
		[param: In]
		set
		{
		}
	}

	private void Initialize()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public virtual void Reset()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckSpeed()
	{
	}

	private void OnAnimatorSpeedChanged(float _, float value)
	{
	}

	private bool CheckAnimStateChanged(out int stateHash, out float normalizedTime, int layerId)
	{
		stateHash = default;
		normalizedTime = default;
		return false;
	}

	private void CheckSendRate()
	{
	}

	private void SendAnimationMessage(int stateHash, float normalizedTime, int layerId, float weight, byte[] parameters)
	{
	}

	private void SendAnimationParametersMessage(byte[] parameters)
	{
	}

	private void HandleAnimMsg(int stateHash, float normalizedTime, int layerId, float weight, NetworkReader reader)
	{
	}

	private void HandleAnimParamsMsg(NetworkReader reader)
	{
	}

	private void HandleAnimTriggerMsg(int hash)
	{
	}

	private void HandleAnimResetTriggerMsg(int hash)
	{
	}

	private ulong NextDirtyBits()
	{
		return 0uL;
	}

	private bool WriteParameters(NetworkWriter writer, bool forceAll = false)
	{
		return false;
	}

	private void ReadParameters(NetworkReader reader)
	{
	}

	public override void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public void SetTrigger(string triggerName)
	{
	}

	public void SetTrigger(int hash)
	{
	}

	public void ResetTrigger(string triggerName)
	{
	}

	public void ResetTrigger(int hash)
	{
	}

	[Command]
	private void CmdOnAnimationServerMessage(int stateHash, float normalizedTime, int layerId, float weight, byte[] parameters)
	{
	}

	[Command]
	private void CmdOnAnimationParametersServerMessage(byte[] parameters)
	{
	}

	[Command]
	private void CmdOnAnimationTriggerServerMessage(int hash)
	{
	}

	[Command]
	private void CmdOnAnimationResetTriggerServerMessage(int hash)
	{
	}

	[Command]
	private void CmdSetAnimatorSpeed(float newSpeed)
	{
	}

	[ClientRpc]
	private void RpcOnAnimationClientMessage(int stateHash, float normalizedTime, int layerId, float weight, byte[] parameters)
	{
	}

	[ClientRpc]
	private void RpcOnAnimationParametersClientMessage(byte[] parameters)
	{
	}

	[ClientRpc(includeOwner = false)]
	private void RpcOnAnimationTriggerClientMessage(int hash)
	{
	}

	[ClientRpc(includeOwner = false)]
	private void RpcOnAnimationResetTriggerClientMessage(int hash)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdOnAnimationServerMessage__Int32__Single__Int32__Single__Byte_005B_005D(int stateHash, float normalizedTime, int layerId, float weight, byte[] parameters)
	{
	}

	protected static void InvokeUserCode_CmdOnAnimationServerMessage__Int32__Single__Int32__Single__Byte_005B_005D(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdOnAnimationParametersServerMessage__Byte_005B_005D(byte[] parameters)
	{
	}

	protected static void InvokeUserCode_CmdOnAnimationParametersServerMessage__Byte_005B_005D(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdOnAnimationTriggerServerMessage__Int32(int hash)
	{
	}

	protected static void InvokeUserCode_CmdOnAnimationTriggerServerMessage__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdOnAnimationResetTriggerServerMessage__Int32(int hash)
	{
	}

	protected static void InvokeUserCode_CmdOnAnimationResetTriggerServerMessage__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdSetAnimatorSpeed__Single(float newSpeed)
	{
	}

	protected static void InvokeUserCode_CmdSetAnimatorSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcOnAnimationClientMessage__Int32__Single__Int32__Single__Byte_005B_005D(int stateHash, float normalizedTime, int layerId, float weight, byte[] parameters)
	{
	}

	protected static void InvokeUserCode_RpcOnAnimationClientMessage__Int32__Single__Int32__Single__Byte_005B_005D(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcOnAnimationParametersClientMessage__Byte_005B_005D(byte[] parameters)
	{
	}

	protected static void InvokeUserCode_RpcOnAnimationParametersClientMessage__Byte_005B_005D(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcOnAnimationTriggerClientMessage__Int32(int hash)
	{
	}

	protected static void InvokeUserCode_RpcOnAnimationTriggerClientMessage__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcOnAnimationResetTriggerClientMessage__Int32(int hash)
	{
	}

	protected static void InvokeUserCode_RpcOnAnimationResetTriggerClientMessage__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static NetworkAnimator()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
