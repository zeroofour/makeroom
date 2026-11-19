using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.AdditiveLevels;

public class Portal : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSendPlayerToNewScene_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject player;

		public Portal _003C_003E4__this;

		private NetworkConnectionToClient _003Cconn_003E5__2;

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
		public _003CSendPlayerToNewScene_003Ed__8(int _003C_003E1__state)
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

	[Tooltip("Which scene to send player from here")]
	[Scene]
	public string destinationScene;

	[Tooltip("Where to spawn player in Destination Scene")]
	public Vector3 startPosition;

	[Tooltip("Reference to child TextMesh label")]
	public TextMesh label;

	[SyncVar(hook = "OnLabelTextChanged")]
	public string labelText;

	public Action<string, string> _Mirror_SyncVarHookDelegate_labelText;

	public string NetworklabelText
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

	public void OnLabelTextChanged(string _, string newValue)
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartClient()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[IteratorStateMachine(typeof(_003CSendPlayerToNewScene_003Ed__8))]
	[ServerCallback]
	private IEnumerator SendPlayerToNewScene(GameObject player)
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
