namespace Mirror.BouncyCastle.Asn1.X509;

public class UserNotice : Asn1Encodable
{
	private readonly NoticeReference noticeRef;

	private readonly DisplayText explicitText;

	public virtual NoticeReference NoticeRef => null;

	public virtual DisplayText ExplicitText => null;

	public UserNotice(NoticeReference noticeRef, DisplayText explicitText)
	{
	}

	public UserNotice(NoticeReference noticeRef, string str)
	{
	}

	private UserNotice(Asn1Sequence seq)
	{
	}

	public static UserNotice GetInstance(object obj)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
