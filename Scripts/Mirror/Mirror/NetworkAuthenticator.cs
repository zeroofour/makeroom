using UnityEngine;
using UnityEngine.Events;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-authenticators")]
public abstract class NetworkAuthenticator : MonoBehaviour
{
	[Tooltip("Mirror has an internal subscriber to this event. You can add your own here.")]
	[Header("Event Listeners (optional)")]
	public UnityEventNetworkConnection OnServerAuthenticated;

	[Tooltip("Mirror has an internal subscriber to this event. You can add your own here.")]
	public UnityEvent OnClientAuthenticated;

	public virtual void OnStartServer()
	{
	}

	public virtual void OnStopServer()
	{
	}

	public virtual void OnServerAuthenticate(NetworkConnectionToClient conn)
	{
	}

	protected void ServerAccept(NetworkConnectionToClient conn)
	{
	}

	protected void ServerReject(NetworkConnectionToClient conn)
	{
	}

	public virtual void OnStartClient()
	{
	}

	public virtual void OnStopClient()
	{
	}

	public virtual void OnClientAuthenticate()
	{
	}

	protected void ClientAccept()
	{
	}

	protected void ClientReject()
	{
	}

	private void Reset()
	{
	}
}
