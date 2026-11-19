using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Examples.Chat;

[AddComponentMenu(null)]
public class ChatAuthenticator : NetworkAuthenticator
{
	public struct AuthRequestMessage : NetworkMessage
	{
		public string authUsername;
	}

	public struct AuthResponseMessage : NetworkMessage
	{
		public byte code;

		public string message;
	}

	[CompilerGenerated]
	private sealed class _003CDelayedDisconnect_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public ChatAuthenticator _003C_003E4__this;

		public NetworkConnectionToClient conn;

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
		public _003CDelayedDisconnect_003Ed__10(int _003C_003E1__state)
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

	private readonly HashSet<NetworkConnectionToClient> connectionsPendingDisconnect;

	internal static readonly HashSet<string> playerNames;

	[Header("Client Username")]
	public string playerName;

	[RuntimeInitializeOnLoadMethod]
	private static void ResetStatics()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnServerAuthenticate(NetworkConnectionToClient conn)
	{
	}

	public void OnAuthRequestMessage(NetworkConnectionToClient conn, AuthRequestMessage msg)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedDisconnect_003Ed__10))]
	private IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime)
	{
		return null;
	}

	public void SetPlayername(string username)
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStopClient()
	{
	}

	public override void OnClientAuthenticate()
	{
	}

	public void OnAuthResponseMessage(AuthResponseMessage msg)
	{
	}
}
