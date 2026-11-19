using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RevDetails : Asn1Encodable
{
	private readonly CertTemplate m_certDetails;

	private readonly X509Extensions m_crlEntryDetails;

	public virtual CertTemplate CertDetails => null;

	public virtual X509Extensions CrlEntryDetails => null;

	public static RevDetails GetInstance(object obj)
	{
		return null;
	}

	public static RevDetails GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private RevDetails(Asn1Sequence seq)
	{
	}

	public RevDetails(CertTemplate certDetails)
	{
	}

	public RevDetails(CertTemplate certDetails, X509Extensions crlEntryDetails)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
