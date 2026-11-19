namespace Mirror.BouncyCastle.Asn1.Cmp;

public class ProtectedPart : Asn1Encodable
{
	private readonly PkiHeader m_header;

	private readonly PkiBody m_body;

	public virtual PkiHeader Header => null;

	public virtual PkiBody Body => null;

	public static ProtectedPart GetInstance(object obj)
	{
		return null;
	}

	public static ProtectedPart GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private ProtectedPart(Asn1Sequence seq)
	{
	}

	public ProtectedPart(PkiHeader header, PkiBody body)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
