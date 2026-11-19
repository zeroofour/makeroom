using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Authenticators;

[AddComponentMenu("Network/ Authenticators/Timeout Authenticator")]
public class TimeoutAuthenticator : NetworkAuthenticator
{
	[CompilerGenerated]
	private sealed class _003CBeginAuthentication_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeoutAuthenticator _003C_003E4__this;

		public NetworkConnection conn;

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
		public _003CBeginAuthentication_003Ed__9(int _003C_003E1__state)
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

	public NetworkAuthenticator authenticator;

	[Range(0f, 600f)]
	[Tooltip("Timeout to auto-disconnect in seconds. Set to 0 for no timeout.")]
	public float timeout;

	public void Awake()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStopClient()
	{
	}

	public override void OnServerAuthenticate(NetworkConnectionToClient conn)
	{
	}

	public override void OnClientAuthenticate()
	{
	}

	[IteratorStateMachine(typeof(_003CBeginAuthentication_003Ed__9))]
	private IEnumerator BeginAuthentication(NetworkConnection conn)
	{
		return null;
	}
}
