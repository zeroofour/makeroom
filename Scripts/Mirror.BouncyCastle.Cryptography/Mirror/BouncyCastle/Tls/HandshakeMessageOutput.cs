using System.IO;

namespace Mirror.BouncyCastle.Tls;

internal sealed class HandshakeMessageOutput : MemoryStream
{
	internal static int GetLength(int bodyLength)
	{
		return 0;
	}

	internal static void Send(TlsProtocol protocol, short handshakeType, byte[] body)
	{
	}

	internal HandshakeMessageOutput(short handshakeType)
	{
	}

	internal HandshakeMessageOutput(short handshakeType, int bodyLength)
	{
	}

	internal void Send(TlsProtocol protocol)
	{
	}

	internal void PrepareClientHello(TlsHandshakeHash handshakeHash, int bindersSize)
	{
	}

	internal void SendClientHello(TlsClientProtocol clientProtocol, TlsHandshakeHash handshakeHash, int bindersSize)
	{
	}
}
