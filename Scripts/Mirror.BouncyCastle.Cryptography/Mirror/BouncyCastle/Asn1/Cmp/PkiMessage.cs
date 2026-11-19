namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PkiMessage : Asn1Encodable
{
	private readonly PkiHeader m_header;

	private readonly PkiBody m_body;

	private readonly DerBitString m_protection;

	private readonly Asn1Sequence m_extraCerts;

	public virtual PkiHeader Header => null;

	public virtual PkiBody Body => null;

	public virtual DerBitString Protection => null;

	public static PkiMessage GetInstance(object obj)
	{
		return null;
	}

	public static PkiMessage GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PkiMessage(Asn1Sequence seq)
	{
	}

	public PkiMessage(PkiHeader header, PkiBody body, DerBitString protection, CmpCertificate[] extraCerts)
	{
	}

	public PkiMessage(PkiHeader header, PkiBody body, DerBitString protection)
	{
	}

	public PkiMessage(PkiHeader header, PkiBody body)
	{
	}

	public virtual CmpCertificate[] GetExtraCerts()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
