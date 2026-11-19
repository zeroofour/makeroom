namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PkiMessages : Asn1Encodable
{
	private Asn1Sequence m_content;

	public static PkiMessages GetInstance(object obj)
	{
		return null;
	}

	public static PkiMessages GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal PkiMessages(Asn1Sequence seq)
	{
	}

	internal PkiMessages(PkiMessages other)
	{
	}

	public PkiMessages(params PkiMessage[] msgs)
	{
	}

	public virtual PkiMessage[] ToPkiMessageArray()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
