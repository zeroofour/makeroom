using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PkiHeader : Asn1Encodable
{
	public static readonly GeneralName NULL_NAME;

	public static readonly int CMP_1999;

	public static readonly int CMP_2000;

	private readonly DerInteger pvno;

	private readonly GeneralName sender;

	private readonly GeneralName recipient;

	private readonly Asn1GeneralizedTime messageTime;

	private readonly AlgorithmIdentifier protectionAlg;

	private readonly Asn1OctetString senderKID;

	private readonly Asn1OctetString recipKID;

	private readonly Asn1OctetString transactionID;

	private readonly Asn1OctetString senderNonce;

	private readonly Asn1OctetString recipNonce;

	private readonly PkiFreeText freeText;

	private readonly Asn1Sequence generalInfo;

	public virtual DerInteger Pvno => null;

	public virtual GeneralName Sender => null;

	public virtual GeneralName Recipient => null;

	public virtual Asn1GeneralizedTime MessageTime => null;

	public virtual AlgorithmIdentifier ProtectionAlg => null;

	public virtual Asn1OctetString SenderKID => null;

	public virtual Asn1OctetString RecipKID => null;

	public virtual Asn1OctetString TransactionID => null;

	public virtual Asn1OctetString SenderNonce => null;

	public virtual Asn1OctetString RecipNonce => null;

	public virtual PkiFreeText FreeText => null;

	public static PkiHeader GetInstance(object obj)
	{
		return null;
	}

	public static PkiHeader GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PkiHeader(Asn1Sequence seq)
	{
	}

	public PkiHeader(int pvno, GeneralName sender, GeneralName recipient)
	{
	}

	private PkiHeader(DerInteger pvno, GeneralName sender, GeneralName recipient)
	{
	}

	public virtual InfoTypeAndValue[] GetGeneralInfo()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
