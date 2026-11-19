using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsCertificate : BcTlsRawKeyCertificate
{
	protected readonly X509CertificateStructure m_certificate;

	public virtual X509CertificateStructure X509CertificateStructure => null;

	public override BigInteger SerialNumber => null;

	public override string SigAlgOid => null;

	public static BcTlsCertificate Convert(BcTlsCrypto crypto, TlsCertificate certificate)
	{
		return null;
	}

	public static X509CertificateStructure ParseCertificate(byte[] encoding)
	{
		return null;
	}

	public BcTlsCertificate(BcTlsCrypto crypto, byte[] encoding)
		: base((BcTlsCrypto)null, (byte[])null)
	{
	}

	public BcTlsCertificate(BcTlsCrypto crypto, X509CertificateStructure certificate)
		: base((BcTlsCrypto)null, (byte[])null)
	{
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public override byte[] GetExtension(DerObjectIdentifier extensionOid)
	{
		return null;
	}

	public override Asn1Encodable GetSigAlgParams()
	{
		return null;
	}

	protected override bool SupportsKeyUsage(int keyUsageBits)
	{
		return false;
	}
}
