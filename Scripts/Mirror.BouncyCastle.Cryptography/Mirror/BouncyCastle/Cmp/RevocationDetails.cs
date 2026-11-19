using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Cmp;

public struct RevocationDetails(RevDetails revDetails)
{
	private readonly RevDetails m_revDetails = null;

	public X509Name Subject => null;

	public X509Name Issuer => null;

	public BigInteger SerialNumber => null;

	public RevDetails ToASN1Structure()
	{
		return null;
	}
}
