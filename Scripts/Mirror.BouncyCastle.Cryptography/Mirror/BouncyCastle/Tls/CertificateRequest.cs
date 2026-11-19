using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateRequest
{
	private readonly byte[] m_certificateRequestContext;

	private readonly short[] m_certificateTypes;

	private readonly IList<SignatureAndHashAlgorithm> m_supportedSignatureAlgorithms;

	private readonly IList<SignatureAndHashAlgorithm> m_supportedSignatureAlgorithmsCert;

	private readonly IList<X509Name> m_certificateAuthorities;

	public short[] CertificateTypes => null;

	public IList<SignatureAndHashAlgorithm> SupportedSignatureAlgorithms => null;

	public IList<SignatureAndHashAlgorithm> SupportedSignatureAlgorithmsCert => null;

	public IList<X509Name> CertificateAuthorities => null;

	private static IList<SignatureAndHashAlgorithm> CheckSupportedSignatureAlgorithms(IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, short alertDescription)
	{
		return null;
	}

	public CertificateRequest(short[] certificateTypes, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, IList<X509Name> certificateAuthorities)
	{
	}

	public CertificateRequest(byte[] certificateRequestContext, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithmsCert, IList<X509Name> certificateAuthorities)
	{
	}

	private CertificateRequest(byte[] certificateRequestContext, short[] certificateTypes, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithms, IList<SignatureAndHashAlgorithm> supportedSignatureAlgorithmsCert, IList<X509Name> certificateAuthorities)
	{
	}

	public byte[] GetCertificateRequestContext()
	{
		return null;
	}

	public bool HasCertificateRequestContext(byte[] certificateRequestContext)
	{
		return false;
	}

	public void Encode(TlsContext context, Stream output)
	{
	}

	public static CertificateRequest Parse(TlsContext context, Stream input)
	{
		return null;
	}
}
