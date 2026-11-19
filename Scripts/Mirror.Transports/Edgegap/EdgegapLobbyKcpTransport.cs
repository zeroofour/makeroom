using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Edgegap;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/edgegap-transports/edgegap-relay")]
public class EdgegapLobbyKcpTransport : EdgegapKcpTransport
{
	public enum TransportStatus
	{
		Offline = 0,
		CreatingLobby = 1,
		StartingLobby = 2,
		JoiningLobby = 3,
		WaitingRelay = 4,
		Connecting = 5,
		Connected = 6,
		Error = 7
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public EdgegapLobbyKcpTransport _003C_003E4__this;

		public bool running;

		public bool forServer;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public bool waitingForResponse;

		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		internal void _003CWaitForLobbyRelay_003Eb__0(Lobby lobby)
		{
		}

		internal void _003CWaitForLobbyRelay_003Eb__1(string error)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitForLobbyRelay_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EdgegapLobbyKcpTransport _003C_003E4__this;

		public bool forServer;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		public string lobbyId;

		private _003C_003Ec__DisplayClass16_1 _003C_003E8__2;

		private double _003CstartTime_003E5__2;

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
		public _003CWaitForLobbyRelay_003Ed__16(int _003C_003E1__state)
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

	[Header("Lobby Settings")]
	[Tooltip("URL to the Edgegap lobby service, automatically filled in after completing the creation process via button below (or enter manually)")]
	public string lobbyUrl;

	[Tooltip("How long to wait for the relay to be assigned after starting a lobby")]
	public float lobbyWaitTimeout;

	public LobbyApi Api;

	private LobbyCreateRequest? _request;

	private string _lobbyId;

	private string _playerId;

	private TransportStatus _status;

	public TransportStatus Status => TransportStatus.Offline;

	protected override void Awake()
	{
	}

	private void Reset()
	{
	}

	public override void ServerStart()
	{
	}

	public override void ServerStop()
	{
	}

	public override void ClientDisconnect()
	{
	}

	public override void ClientConnect(string address)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForLobbyRelay_003Ed__16))]
	private IEnumerator WaitForLobbyRelay(string lobbyId, bool forServer)
	{
		return null;
	}

	private static string RandomPlayerId()
	{
		return null;
	}

	public void SetServerLobbyParams(string lobbyName, int capacity)
	{
	}

	public void SetServerLobbyParams(LobbyCreateRequest request)
	{
	}

	private void OnDestroy()
	{
	}
}
