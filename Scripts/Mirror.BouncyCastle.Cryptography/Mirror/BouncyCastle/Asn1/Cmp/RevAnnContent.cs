using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RevAnnContent : Asn1Encodable
{
	private readonly PkiStatusEncodable m_status;

	private readonly CertId m_certID;

	private readonly Asn1GeneralizedTime m_willBeRevokedAt;

	private readonly Asn1GeneralizedTime m_badSinceDate;

	private readonly X509Extensions m_crlDetails;

	public virtual PkiStatusEncodable Status => null;

	public virtual CertId CertID => null;

	public virtual Asn1GeneralizedTime WillBeRevokedAt => null;

	public virtual Asn1GeneralizedTime BadSinceDate => null;

	public virtual X509Extensions CrlDetails => null;

	public static RevAnnContent GetInstance(object obj)
	{
		return null;
	}

	public static RevAnnContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public RevAnnContent(PkiStatusEncodable status, CertId certID, Asn1GeneralizedTime willBeRevokedAt, Asn1GeneralizedTime badSinceDate)
	{
	}

	public RevAnnContent(PkiStatusEncodable status, CertId certID, Asn1GeneralizedTime willBeRevokedAt, Asn1GeneralizedTime badSinceDate, X509Extensions crlDetails)
	{
	}

	private RevAnnContent(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
