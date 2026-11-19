using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ClientHello
{
	private readonly ProtocolVersion m_version;

	private readonly byte[] m_random;

	private readonly byte[] m_sessionID;

	private readonly byte[] m_cookie;

	private readonly int[] m_cipherSuites;

	private readonly IDictionary<int, byte[]> m_extensions;

	private readonly int m_bindersSize;

	public int BindersSize => 0;

	public int[] CipherSuites => null;

	public byte[] Cookie => null;

	public IDictionary<int, byte[]> Extensions => null;

	public byte[] Random => null;

	public byte[] SessionID => null;

	public ProtocolVersion Version => null;

	public ClientHello(ProtocolVersion version, byte[] random, byte[] sessionID, byte[] cookie, int[] cipherSuites, IDictionary<int, byte[]> extensions, int bindersSize)
	{
	}

	public void Encode(TlsContext context, Stream output)
	{
	}

	public static ClientHello Parse(MemoryStream messageInput, Stream dtlsOutput)
	{
		return null;
	}

	private static ClientHello ImplParse(MemoryStream messageInput, Stream dtlsOutput)
	{
		return null;
	}
}
