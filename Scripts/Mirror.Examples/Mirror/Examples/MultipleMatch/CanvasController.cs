using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

public class CanvasController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnServerDisconnect_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasController _003C_003E4__this;

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
		public _003COnServerDisconnect_003Ed__34(int _003C_003E1__state)
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
	private Action<NetworkConnectionToClient> m_OnPlayerDisconnect;

	internal static readonly Dictionary<NetworkConnectionToClient, Guid> playerMatches;

	internal static readonly Dictionary<Guid, MatchInfo> openMatches;

	internal static readonly Dictionary<Guid, HashSet<NetworkConnectionToClient>> matchConnections;

	internal static readonly Dictionary<NetworkConnectionToClient, PlayerInfo> playerInfos;

	internal static readonly List<NetworkConnectionToClient> waitingConnections;

	internal Guid localPlayerMatch;

	internal Guid localJoinedMatch;

	internal Guid selectedMatch;

	private int playerIndex;

	[Header("GUI References")]
	public GameObject matchList;

	public GameObject matchPrefab;

	public GameObject matchControllerPrefab;

	public Button createButton;

	public Button joinButton;

	public GameObject lobbyView;

	public GameObject roomView;

	public RoomGUI roomGUI;

	public ToggleGroup toggleGroup;

	public event Action<NetworkConnectionToClient> OnPlayerDisconnect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void ResetStatics()
	{
	}

	internal void InitializeData()
	{
	}

	private void ResetCanvas()
	{
	}

	[ClientCallback]
	public void SelectMatch(Guid matchId)
	{
	}

	[ClientCallback]
	public void RequestCreateMatch()
	{
	}

	[ClientCallback]
	public void RequestCancelMatch()
	{
	}

	[ClientCallback]
	public void RequestJoinMatch()
	{
	}

	[ClientCallback]
	public void RequestLeaveMatch()
	{
	}

	[ClientCallback]
	public void RequestReadyChange()
	{
	}

	[ClientCallback]
	public void RequestStartMatch()
	{
	}

	[ClientCallback]
	public void OnMatchEnded()
	{
	}

	[ServerCallback]
	internal void OnStartServer()
	{
	}

	[ServerCallback]
	internal void OnServerReady(NetworkConnectionToClient conn)
	{
	}

	[IteratorStateMachine(typeof(_003COnServerDisconnect_003Ed__34))]
	[ServerCallback]
	internal IEnumerator OnServerDisconnect(NetworkConnectionToClient conn)
	{
		return null;
	}

	[ServerCallback]
	internal void OnStopServer()
	{
	}

	[ClientCallback]
	internal void OnStartClient()
	{
	}

	[ClientCallback]
	internal void OnClientDisconnect()
	{
	}

	[ClientCallback]
	internal void OnStopClient()
	{
	}

	[ServerCallback]
	private void OnServerMatchMessage(NetworkConnectionToClient conn, ServerMatchMessage msg)
	{
	}

	[ServerCallback]
	private void OnServerCreateMatch(NetworkConnectionToClient conn)
	{
	}

	[ServerCallback]
	private void OnServerCancelMatch(NetworkConnectionToClient conn)
	{
	}

	[ServerCallback]
	private void OnServerJoinMatch(NetworkConnectionToClient conn, Guid matchId)
	{
	}

	[ServerCallback]
	private void OnServerLeaveMatch(NetworkConnectionToClient conn, Guid matchId)
	{
	}

	[ServerCallback]
	private void OnServerPlayerReady(NetworkConnectionToClient conn, Guid matchId)
	{
	}

	[ServerCallback]
	private void OnServerStartMatch(NetworkConnectionToClient conn)
	{
	}

	[ServerCallback]
	internal void SendMatchList(NetworkConnectionToClient conn = null)
	{
	}

	[ClientCallback]
	private void OnClientMatchMessage(ClientMatchMessage msg)
	{
	}

	[ClientCallback]
	private void ShowLobbyView()
	{
	}

	[ClientCallback]
	private void ShowRoomView()
	{
	}

	[ClientCallback]
	private void RefreshMatchList()
	{
	}
}
