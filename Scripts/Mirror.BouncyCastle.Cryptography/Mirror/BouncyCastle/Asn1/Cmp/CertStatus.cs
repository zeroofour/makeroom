using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class CertStatus : Asn1Encodable
{
	private readonly Asn1OctetString m_certHash;

	private readonly DerInteger m_certReqID;

	private readonly PkiStatusInfo m_statusInfo;

	private readonly AlgorithmIdentifier m_hashAlg;

	public virtual Asn1OctetString CertHash => null;

	public virtual DerInteger CertReqID => null;

	public virtual PkiStatusInfo StatusInfo => null;

	public virtual AlgorithmIdentifier HashAlg => null;

	public static CertStatus GetInstance(object obj)
	{
		return null;
	}

	public static CertStatus GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CertStatus(Asn1Sequence seq)
	{
	}

	public CertStatus(byte[] certHash, BigInteger certReqID)
	{
	}

	public CertStatus(byte[] certHash, DerInteger certReqID)
	{
	}

	public CertStatus(byte[] certHash, BigInteger certReqID, PkiStatusInfo statusInfo)
	{
	}

	public CertStatus(byte[] certHash, BigInteger certReqID, PkiStatusInfo statusInfo, AlgorithmIdentifier hashAlg)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
