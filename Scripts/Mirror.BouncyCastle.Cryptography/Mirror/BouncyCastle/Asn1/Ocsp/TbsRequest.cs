using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class TbsRequest : Asn1Encodable
{
	private static readonly DerInteger V1;

	private readonly DerInteger m_version;

	private readonly bool m_versionPresent;

	private readonly GeneralName m_requestorName;

	private readonly Asn1Sequence m_requestList;

	private readonly X509Extensions m_requestExtensions;

	public DerInteger Version => null;

	public GeneralName RequestorName => null;

	public Asn1Sequence RequestList => null;

	public X509Extensions RequestExtensions => null;

	public static TbsRequest GetInstance(object obj)
	{
		return null;
	}

	public static TbsRequest GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public TbsRequest(GeneralName requestorName, Asn1Sequence requestList, X509Extensions requestExtensions)
	{
	}

	private TbsRequest(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
