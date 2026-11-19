using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Authenticators;

[AddComponentMenu("Network/ Authenticators/Device Authenticator")]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-authenticators/device-authenticator")]
public class DeviceAuthenticator : NetworkAuthenticator
{
	public struct AuthRequestMessage : NetworkMessage
	{
		public string clientDeviceID;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct AuthResponseMessage : NetworkMessage
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

	private void OnAuthRequestMessage(NetworkConnectionToClient conn, AuthRequestMessage msg)
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
