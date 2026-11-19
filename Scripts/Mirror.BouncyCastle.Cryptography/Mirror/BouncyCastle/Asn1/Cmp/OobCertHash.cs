using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class OobCertHash : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_hashAlg;

	private readonly CertId m_certId;

	private readonly DerBitString m_hashVal;

	public virtual CertId CertID => null;

	public virtual AlgorithmIdentifier HashAlg => null;

	public virtual DerBitString HashVal => null;

	public static OobCertHash GetInstance(object obj)
	{
		return null;
	}

	public static OobCertHash GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private OobCertHash(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
