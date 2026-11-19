using System;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class NestedMessageContent : PkiMessages
{
	public new static NestedMessageContent GetInstance(object obj)
	{
		return null;
	}

	public new static NestedMessageContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public NestedMessageContent(PkiMessage msg)
		: base((Asn1Sequence)null)
	{
	}

	public NestedMessageContent(PkiMessage[] msgs)
		: base((Asn1Sequence)null)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public NestedMessageContent(Asn1Sequence seq)
		: base((Asn1Sequence)null)
	{
	}

	internal NestedMessageContent(PkiMessages other)
		: base((Asn1Sequence)null)
	{
	}
}
