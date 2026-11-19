using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateVerify
{
	private readonly int m_algorithm;

	private readonly byte[] m_signature;

	public int Algorithm => 0;

	public byte[] Signature => null;

	public CertificateVerify(int algorithm, byte[] signature)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static CertificateVerify Parse(TlsContext context, Stream input)
	{
		return null;
	}
}
