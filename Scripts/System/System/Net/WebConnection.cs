using System.IO;
using System.Net.Sockets;
using Mono.Net.Security;

namespace System.Net;

internal class WebConnection : IDisposable
{
	private NetworkCredential ntlm_credentials;

	private bool ntlm_authenticated;

	private bool unsafe_sharing;

	private Stream networkStream;

	private Socket socket;

	private MonoTlsStream monoTlsStream;

	private WebConnectionTunnel tunnel;

	private int disposed;

	private void Reset()
	{
	}

	private void Close(bool reset)
	{
	}

	private void CloseSocket()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	private void ResetNtlm()
	{
	}
}
