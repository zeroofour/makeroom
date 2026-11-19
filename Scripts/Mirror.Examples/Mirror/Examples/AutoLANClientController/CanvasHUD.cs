using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror.Discovery;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.AutoLANClientController;

public class CanvasHUD : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaiter_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasHUD _003C_003E4__this;

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
		public _003CWaiter_003Ed__14(int _003C_003E1__state)
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

	public bool alwaysAutoStart;

	public AutoLANNetworkDiscovery networkDiscovery;

	private readonly Dictionary<long, ServerResponse> discoveredServers;

	public bool runAsPlayerHost;

	public GameObject PanelStart;

	public GameObject PanelStop;

	public Button buttonHost;

	public Button buttonServer;

	public Button buttonClient;

	public Button buttonStop;

	public Button buttonAuto;

	public Text infoText;

	public InputField inputFieldAddress;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CWaiter_003Ed__14))]
	public IEnumerator Waiter()
	{
		return null;
	}

	private void Connect(ServerResponse info)
	{
	}

	public void OnDiscoveredServer(ServerResponse info)
	{
	}

	public void ButtonHost()
	{
	}

	public void ButtonServer()
	{
	}

	public void ButtonClient()
	{
	}

	public void ButtonStop()
	{
	}

	public void ButtonAuto()
	{
	}

	public void SetupCanvas()
	{
	}

	public void SetupInfoText(string _info)
	{
	}

	public void OnValueChangedAddress()
	{
	}
}
