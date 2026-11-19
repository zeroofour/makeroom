using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class Certificate
{
	public sealed class ParseOptions
	{
		public short CertificateType { get; set; }

		public int MaxChainLength { get; set; }
	}

	private static readonly TlsCertificate[] EmptyCerts;

	private static readonly CertificateEntry[] EmptyCertEntries;

	public static readonly Certificate EmptyChain;

	public static readonly Certificate EmptyChainTls13;

	private readonly byte[] m_certificateRequestContext;

	private readonly CertificateEntry[] m_certificateEntryList;

	private readonly short m_certificateType;

	public short CertificateType => 0;

	public int Length => 0;

	public bool IsEmpty => false;

	private static CertificateEntry[] Convert(TlsCertificate[] certificateList)
	{
		return null;
	}

	public Certificate(TlsCertificate[] certificateList)
	{
	}

	public Certificate(byte[] certificateRequestContext, CertificateEntry[] certificateEntryList)
	{
	}

	public Certificate(short certificateType, byte[] certificateRequestContext, CertificateEntry[] certificateEntryList)
	{
	}

	public byte[] GetCertificateRequestContext()
	{
		return null;
	}

	public TlsCertificate[] GetCertificateList()
	{
		return null;
	}

	public TlsCertificate GetCertificateAt(int index)
	{
		return null;
	}

	public CertificateEntry GetCertificateEntryAt(int index)
	{
		return null;
	}

	public CertificateEntry[] GetCertificateEntryList()
	{
		return null;
	}

	public void Encode(TlsContext context, Stream messageOutput, Stream endPointHashOutput)
	{
	}

	public static Certificate Parse(ParseOptions options, TlsContext context, Stream messageInput, Stream endPointHashOutput)
	{
		return null;
	}

	private static void CalculateEndPointHash(TlsContext context, TlsCertificate cert, byte[] encoding, Stream output)
	{
	}

	private TlsCertificate[] CloneCertificateList()
	{
		return null;
	}

	private CertificateEntry[] CloneCertificateEntryList()
	{
		return null;
	}
}
