using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Examples.AdditiveScenes;

[AddComponentMenu(null)]
public class AdditiveNetworkManager : NetworkManager
{
	[CompilerGenerated]
	private sealed class _003CLoadSubScenes_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveNetworkManager _003C_003E4__this;

		private string[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		public _003CLoadSubScenes_003Ed__5(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUnloadScenes_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveNetworkManager _003C_003E4__this;

		private string[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		public _003CUnloadScenes_003Ed__6(int _003C_003E1__state)
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

	[Tooltip("Trigger Zone Prefab")]
	public GameObject Zone;

	[Scene]
	[Tooltip("Add all sub-scenes to this list")]
	public string[] subScenes;

	public override void OnStartServer()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStopClient()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSubScenes_003Ed__5))]
	private IEnumerator LoadSubScenes()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUnloadScenes_003Ed__6))]
	private IEnumerator UnloadScenes()
	{
		return null;
	}
}
