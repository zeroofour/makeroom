using System;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class RecipientKeyIdentifier : Asn1Encodable
{
	private Asn1OctetString subjectKeyIdentifier;

	private Asn1GeneralizedTime date;

	private OtherKeyAttribute other;

	public Asn1OctetString SubjectKeyIdentifier => null;

	public Asn1GeneralizedTime Date => null;

	public OtherKeyAttribute OtherKeyAttribute => null;

	public static RecipientKeyIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static RecipientKeyIdentifier GetInstance(Asn1TaggedObject ato, bool explicitly)
	{
		return null;
	}

	public RecipientKeyIdentifier(Asn1OctetString subjectKeyIdentifier, Asn1GeneralizedTime date, OtherKeyAttribute other)
	{
	}

	public RecipientKeyIdentifier(byte[] subjectKeyIdentifier)
	{
	}

	public RecipientKeyIdentifier(byte[] subjectKeyIdentifier, Asn1GeneralizedTime date, OtherKeyAttribute other)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public RecipientKeyIdentifier(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
