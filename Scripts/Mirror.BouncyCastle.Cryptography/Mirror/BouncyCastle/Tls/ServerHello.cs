using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ServerHello
{
	private static readonly byte[] HelloRetryRequestMagic;

	private readonly ProtocolVersion m_version;

	private readonly byte[] m_random;

	private readonly byte[] m_sessionID;

	private readonly int m_cipherSuite;

	private readonly IDictionary<int, byte[]> m_extensions;

	public int CipherSuite => 0;

	public IDictionary<int, byte[]> Extensions => null;

	public byte[] Random => null;

	public byte[] SessionID => null;

	public ProtocolVersion Version => null;

	public ServerHello(byte[] sessionID, int cipherSuite, IDictionary<int, byte[]> extensions)
	{
	}

	public ServerHello(ProtocolVersion version, byte[] random, byte[] sessionID, int cipherSuite, IDictionary<int, byte[]> extensions)
	{
	}

	public bool IsHelloRetryRequest()
	{
		return false;
	}

	public void Encode(TlsContext context, Stream output)
	{
	}

	public static ServerHello Parse(MemoryStream input)
	{
		return null;
	}
}
