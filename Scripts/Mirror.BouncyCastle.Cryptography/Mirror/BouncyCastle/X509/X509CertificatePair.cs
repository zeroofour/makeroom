using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.X509;

public class X509CertificatePair
{
	private readonly X509Certificate m_forward;

	private readonly X509Certificate m_reverse;

	public X509Certificate Forward => null;

	public X509Certificate Reverse => null;

	public X509CertificatePair(X509Certificate forward, X509Certificate reverse)
	{
	}

	public X509CertificatePair(CertificatePair pair)
	{
	}

	public CertificatePair GetCertificatePair()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
