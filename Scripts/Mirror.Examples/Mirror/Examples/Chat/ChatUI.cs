using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Chat;

public class ChatUI : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAppendAndScroll_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatUI _003C_003E4__this;

		public string message;

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
		public _003CAppendAndScroll_003Ed__11(int _003C_003E1__state)
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

	[Header("UI Elements")]
	[SerializeField]
	private Text chatHistory;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private InputField chatMessage;

	[SerializeField]
	private Button sendButton;

	internal static string localPlayerName;

	internal static readonly Dictionary<NetworkConnectionToClient, string> connNames;

	public override void OnStartServer()
	{
	}

	public override void OnStartClient()
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdSend(string message, NetworkConnectionToClient sender = null)
	{
	}

	[ClientRpc]
	private void RpcReceive(string playerName, string message)
	{
	}

	private void AppendMessage(string message)
	{
	}

	[IteratorStateMachine(typeof(_003CAppendAndScroll_003Ed__11))]
	private IEnumerator AppendAndScroll(string message)
	{
		return null;
	}

	public void ExitButtonOnClick()
	{
	}

	public void ToggleButton(string input)
	{
	}

	public void OnEndEdit(string input)
	{
	}

	public void SendMessage()
	{
	}

	static ChatUI()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdSend__String__NetworkConnectionToClient(string message, NetworkConnectionToClient sender)
	{
	}

	protected static void InvokeUserCode_CmdSend__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcReceive__String__String(string playerName, string message)
	{
	}

	protected static void InvokeUserCode_RpcReceive__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}
}
