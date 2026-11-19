using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.Cms;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class TimeStampResp : Asn1Encodable
{
	private readonly PkiStatusInfo m_pkiStatusInfo;

	private readonly ContentInfo m_timeStampToken;

	public PkiStatusInfo Status => null;

	public ContentInfo TimeStampToken => null;

	public static TimeStampResp GetInstance(object obj)
	{
		return null;
	}

	public static TimeStampResp GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private TimeStampResp(Asn1Sequence seq)
	{
	}

	public TimeStampResp(PkiStatusInfo pkiStatusInfo, ContentInfo timeStampToken)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
