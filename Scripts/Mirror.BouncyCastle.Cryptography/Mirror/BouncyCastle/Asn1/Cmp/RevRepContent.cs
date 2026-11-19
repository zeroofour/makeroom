using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class RevRepContent : Asn1Encodable
{
	private readonly Asn1Sequence m_status;

	private readonly Asn1Sequence m_revCerts;

	private readonly Asn1Sequence m_crls;

	public static RevRepContent GetInstance(object obj)
	{
		return null;
	}

	public static RevRepContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private RevRepContent(Asn1Sequence seq)
	{
	}

	public virtual PkiStatusInfo[] GetStatus()
	{
		return null;
	}

	public virtual CertId[] GetRevCerts()
	{
		return null;
	}

	public virtual CertificateList[] GetCrls()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
