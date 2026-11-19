using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.PickupsDropsChilds;

[RequireComponent(typeof(Rigidbody))]
public class SceneObject : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeEquipment_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneObject _003C_003E4__this;

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
		public _003CChangeEquipment_003Ed__14(int _003C_003E1__state)
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

	[Header("Prefabs")]
	public GameObject ballPrefab;

	public GameObject batPrefab;

	public GameObject boxPrefab;

	[Range(0f, 5f)]
	[Header("Settings")]
	public float force;

	[Header("SyncVars in Specific Order")]
	[SyncVar(hook = "OnChangeEquippedItemConfig")]
	public EquippedItemConfig equippedItemConfig;

	[SyncVar(hook = "OnChangeEquipment")]
	public EquippedItem equippedItem;

	[Header("Diagnostics")]
	[ReadOnly]
	public GameObject equippedObject;

	[ReadOnly]
	public Vector3 direction;

	[ReadOnly]
	[SerializeField]
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

	protected override void OnValidate()
	{
	}

	public override void OnStartServer()
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnChangeEquippedItemConfig(EquippedItemConfig _, EquippedItemConfig newEquippedItemConfig)
	{
	}

	private void OnChangeEquipment(EquippedItem _, EquippedItem newEquippedItem)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeEquipment_003Ed__14))]
	private IEnumerator ChangeEquipment()
	{
		return null;
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
