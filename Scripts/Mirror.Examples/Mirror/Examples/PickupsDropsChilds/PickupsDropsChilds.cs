using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.PickupsDropsChilds;

public class PickupsDropsChilds : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeEquipment_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupsDropsChilds _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CChangeEquipment_003Ed__12(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Player Components")]
	public GameObject rightHand;

	[Header("Prefabs")]
	public GameObject ballPrefab;

	public GameObject batPrefab;

	public GameObject boxPrefab;

	public GameObject sceneObjectPrefab;

	[Header("SyncVars in Specific Order")]
	[SyncVar(hook = "OnChangeEquippedItemConfig")]
	public EquippedItemConfig equippedItemConfig;

	[SyncVar(hook = "OnChangeEquipment")]
	public EquippedItem equippedItem;

	[ReadOnly]
	[Header("Diagnostics")]
	public GameObject equippedObject;

	private IEquipped iEquipped;

	public Action<EquippedItemConfig, EquippedItemConfig> _Mirror_SyncVarHookDelegate_equippedItemConfig;

	public Action<EquippedItem, EquippedItem> _Mirror_SyncVarHookDelegate_equippedItem;

	public EquippedItemConfig NetworkequippedItemConfig
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

	public EquippedItem NetworkequippedItem
	{
		get
		{
			return EquippedItem.nothing;
		}
		[param: In]
		set
		{
		}
	}

	private void Update()
	{
	}

	private void OnChangeEquippedItemConfig(EquippedItemConfig _, EquippedItemConfig newEquippedItemConfig)
	{
	}

	private void OnChangeEquipment(EquippedItem _, EquippedItem newEquippedItem)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeEquipment_003Ed__12))]
	private IEnumerator ChangeEquipment()
	{
		return null;
	}

	[Command]
	private void CmdChangeEquippedItem(EquippedItem selectedItem)
	{
	}

	[Command]
	public void CmdUseItem()
	{
	}

	[Command]
	public void CmdAddUsages(byte usages)
	{
	}

	[Command]
	public void CmdResetUsages()
	{
	}

	[Command]
	public void CmdResetUsages(byte usages)
	{
	}

	[Command]
	private void CmdDropItem()
	{
	}

	[Command]
	public void CmdPickupItem(GameObject obj)
	{
	}

	[ClientRpc]
	public void RpcUseItem()
	{
	}

	[ClientRpc]
	public void RpcAddUsages(byte usages)
	{
	}

	[ClientRpc]
	public void RpcResetUsages()
	{
	}

	[ClientRpc]
	public void RpcResetUsages(byte usages)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdChangeEquippedItem__EquippedItem(EquippedItem selectedItem)
	{
	}

	protected static void InvokeUserCode_CmdChangeEquippedItem__EquippedItem(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdUseItem()
	{
	}

	protected static void InvokeUserCode_CmdUseItem(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdAddUsages__Byte(byte usages)
	{
	}

	protected static void InvokeUserCode_CmdAddUsages__Byte(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdResetUsages()
	{
	}

	protected static void InvokeUserCode_CmdResetUsages(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdResetUsages__Byte(byte usages)
	{
	}

	protected static void InvokeUserCode_CmdResetUsages__Byte(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdDropItem()
	{
	}

	protected static void InvokeUserCode_CmdDropItem(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdPickupItem__GameObject(GameObject obj)
	{
	}

	protected static void InvokeUserCode_CmdPickupItem__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcUseItem()
	{
	}

	protected static void InvokeUserCode_RpcUseItem(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcAddUsages__Byte(byte usages)
	{
	}

	protected static void InvokeUserCode_RpcAddUsages__Byte(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcResetUsages()
	{
	}

	protected static void InvokeUserCode_RpcResetUsages(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcResetUsages__Byte(byte usages)
	{
	}

	protected static void InvokeUserCode_RpcResetUsages__Byte(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static PickupsDropsChilds()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
