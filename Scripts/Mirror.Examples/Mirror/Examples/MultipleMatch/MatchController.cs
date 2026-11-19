using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

[RequireComponent(typeof(NetworkMatch))]
public class MatchController : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAddPlayersToMatchController_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MatchController _003C_003E4__this;

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
		public _003CAddPlayersToMatchController_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CServerEndMatch_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MatchController _003C_003E4__this;

		public bool disconnected;

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
		public _003CServerEndMatch_003Ed__32(int _003C_003E1__state)
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

	internal readonly SyncDictionary<NetworkIdentity, MatchPlayerData> matchPlayerData;

	internal readonly Dictionary<CellValue, CellGUI> MatchCells;

	private CellValue boardScore;

	private bool playAgain;

	[Header("GUI References")]
	public CanvasGroup canvasGroup;

	public Text gameText;

	public Button exitButton;

	public Button playAgainButton;

	public Text winCountLocal;

	public Text winCountOpponent;

	[Header("Diagnostics")]
	[SerializeField]
	[ReadOnly]
	internal CanvasController canvasController;

	[ReadOnly]
	[SerializeField]
	internal NetworkIdentity player1;

	[SerializeField]
	[ReadOnly]
	internal NetworkIdentity player2;

	[SerializeField]
	[ReadOnly]
	internal NetworkIdentity startingPlayer;

	[SerializeField]
	[ReadOnly]
	[SyncVar(hook = "UpdateGameUI")]
	internal NetworkIdentity currentPlayer;

	protected uint ___currentPlayerNetId;

	public Action<NetworkIdentity, NetworkIdentity> _Mirror_SyncVarHookDelegate_currentPlayer;

	public NetworkIdentity NetworkcurrentPlayer
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

	private void Awake()
	{
	}

	public override void OnStartServer()
	{
	}

	[IteratorStateMachine(typeof(_003CAddPlayersToMatchController_003Ed__17))]
	private IEnumerator AddPlayersToMatchController()
	{
		return null;
	}

	public override void OnStartClient()
	{
	}

	[ClientCallback]
	public void UpdateGameUI(NetworkIdentity _, NetworkIdentity newPlayerTurn)
	{
	}

	[ClientCallback]
	public void UpdateWins(SyncIDictionary<NetworkIdentity, MatchPlayerData>.Operation op, NetworkIdentity key, MatchPlayerData matchPlayerData)
	{
	}

	[Command(requiresAuthority = false)]
	public void CmdMakePlay(CellValue cellValue, NetworkConnectionToClient sender = null)
	{
	}

	[ServerCallback]
	private bool CheckWinner(CellValue currentScore)
	{
		return false;
	}

	[ClientRpc]
	public void RpcUpdateCell(CellValue cellValue, NetworkIdentity player)
	{
	}

	[ClientRpc]
	public void RpcShowWinner(NetworkIdentity winner)
	{
	}

	[ClientCallback]
	public void RequestPlayAgain()
	{
	}

	[Command(requiresAuthority = false)]
	public void CmdPlayAgain(NetworkConnectionToClient sender = null)
	{
	}

	[ServerCallback]
	public void RestartGame()
	{
	}

	[ClientRpc]
	public void RpcRestartGame()
	{
	}

	[Client]
	public void RequestExitGame()
	{
	}

	[Command(requiresAuthority = false)]
	public void CmdRequestExitGame(NetworkConnectionToClient sender = null)
	{
	}

	[ServerCallback]
	public void OnPlayerDisconnect(NetworkConnectionToClient conn)
	{
	}

	[IteratorStateMachine(typeof(_003CServerEndMatch_003Ed__32))]
	[ServerCallback]
	public IEnumerator ServerEndMatch(NetworkConnectionToClient conn, bool disconnected)
	{
		return null;
	}

	[ClientRpc]
	public void RpcExitGame()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdMakePlay__CellValue__NetworkConnectionToClient(CellValue cellValue, NetworkConnectionToClient sender)
	{
	}

	protected static void InvokeUserCode_CmdMakePlay__CellValue__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcUpdateCell__CellValue__NetworkIdentity(CellValue cellValue, NetworkIdentity player)
	{
	}

	protected static void InvokeUserCode_RpcUpdateCell__CellValue__NetworkIdentity(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcShowWinner__NetworkIdentity(NetworkIdentity winner)
	{
	}

	protected static void InvokeUserCode_RpcShowWinner__NetworkIdentity(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdPlayAgain__NetworkConnectionToClient(NetworkConnectionToClient sender)
	{
	}

	protected static void InvokeUserCode_CmdPlayAgain__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcRestartGame()
	{
	}

	protected static void InvokeUserCode_RpcRestartGame(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdRequestExitGame__NetworkConnectionToClient(NetworkConnectionToClient sender)
	{
	}

	protected static void InvokeUserCode_CmdRequestExitGame__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcExitGame()
	{
	}

	protected static void InvokeUserCode_RpcExitGame(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static MatchController()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
