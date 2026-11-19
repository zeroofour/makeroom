using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class IssuerAndSerialNumber : Asn1Encodable
{
	private X509Name m_name;

	private DerInteger m_serialNumber;

	public X509Name Name => null;

	public DerInteger SerialNumber => null;

	public static IssuerAndSerialNumber GetInstance(object obj)
	{
		return null;
	}

	public static IssuerAndSerialNumber GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private IssuerAndSerialNumber(Asn1Sequence seq)
	{
	}

	public IssuerAndSerialNumber(X509Name name, BigInteger serialNumber)
	{
	}

	public IssuerAndSerialNumber(X509Name name, DerInteger serialNumber)
	{
	}

	public IssuerAndSerialNumber(X509CertificateStructure x509CertificateStructure)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
