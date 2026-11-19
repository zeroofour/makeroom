using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Mirror.Discovery;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-discovery")]
public abstract class NetworkDiscoveryBase<Request, Response> : MonoBehaviour where Request : NetworkMessage where Response : NetworkMessage
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CServerListenAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NetworkDiscoveryBase<Request, Response> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReceiveRequestAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UdpClient udpClient;

		public NetworkDiscoveryBase<Request, Response> _003C_003E4__this;

		private TaskAwaiter<UdpReceiveResult> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CClientListenAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NetworkDiscoveryBase<Request, Response> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReceiveGameBroadcastAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UdpClient udpClient;

		public NetworkDiscoveryBase<Request, Response> _003C_003E4__this;

		private TaskAwaiter<UdpReceiveResult> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[Tooltip("If true, broadcasts a discovery request every ActiveDiscoveryInterval seconds")]
	[SerializeField]
	public bool enableActiveDiscovery;

	[Tooltip("iOS may require LAN IP address here (e.g. 192.168.x.x), otherwise leave blank.")]
	public string BroadcastAddress;

	[Tooltip("The UDP port the server will listen for multi-cast messages")]
	[SerializeField]
	protected int serverBroadcastListenPort;

	[Tooltip("Time in seconds between multi-cast messages")]
	[SerializeField]
	[Range(1f, 60f)]
	private float ActiveDiscoveryInterval;

	[Tooltip("Transport to be advertised during discovery")]
	public Transport transport;

	[Tooltip("Invoked when a server is found")]
	public ServerFoundUnityEvent<Response> OnServerFound;

	[HideInInspector]
	public long secretHandshake;

	protected UdpClient serverUdpClient;

	protected UdpClient clientUdpClient;

	public static bool SupportedOnThisPlatform => false;

	public long ServerId { get; private set; }

	public virtual void Start()
	{
	}

	public static long RandomLong()
	{
		return 0L;
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Shutdown()
	{
	}

	public void AdvertiseServer()
	{
	}

	[AsyncStateMachine(typeof(NetworkDiscoveryBase<, >._003CServerListenAsync_003Ed__22))]
	public Task ServerListenAsync()
	{
		return null;
	}

	[AsyncStateMachine(typeof(NetworkDiscoveryBase<, >._003CReceiveRequestAsync_003Ed__23))]
	private Task ReceiveRequestAsync(UdpClient udpClient)
	{
		return null;
	}

	protected virtual void ProcessClientRequest(Request request, IPEndPoint endpoint)
	{
	}

	protected abstract Response ProcessRequest(Request request, IPEndPoint endpoint);

	private void BeginMulticastLock()
	{
	}

	private void EndpMulticastLock()
	{
	}

	public void StartDiscovery()
	{
	}

	public void StopDiscovery()
	{
	}

	[AsyncStateMachine(typeof(NetworkDiscoveryBase<, >._003CClientListenAsync_003Ed__30))]
	public Task ClientListenAsync()
	{
		return null;
	}

	public void BroadcastDiscoveryRequest()
	{
	}

	protected virtual Request GetRequest()
	{
		return default;
	}

	[AsyncStateMachine(typeof(NetworkDiscoveryBase<, >._003CReceiveGameBroadcastAsync_003Ed__33))]
	private Task ReceiveGameBroadcastAsync(UdpClient udpClient)
	{
		return null;
	}

	protected abstract void ProcessResponse(Response response, IPEndPoint endpoint);
}
