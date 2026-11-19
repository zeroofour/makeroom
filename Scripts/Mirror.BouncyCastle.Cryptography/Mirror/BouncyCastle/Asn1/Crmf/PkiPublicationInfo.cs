using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class PkiPublicationInfo : Asn1Encodable
{
	public static readonly DerInteger DontPublish;

	public static readonly DerInteger PleasePublish;

	private readonly DerInteger m_action;

	private readonly Asn1Sequence m_pubInfos;

	public virtual DerInteger Action => null;

	public static PkiPublicationInfo GetInstance(object obj)
	{
		return null;
	}

	private PkiPublicationInfo(Asn1Sequence seq)
	{
	}

	public PkiPublicationInfo(BigInteger action)
	{
	}

	public PkiPublicationInfo(DerInteger action)
	{
	}

	public PkiPublicationInfo(SinglePubInfo pubInfo)
	{
	}

	public PkiPublicationInfo(SinglePubInfo[] pubInfos)
	{
	}

	public virtual SinglePubInfo[] GetPubInfos()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
