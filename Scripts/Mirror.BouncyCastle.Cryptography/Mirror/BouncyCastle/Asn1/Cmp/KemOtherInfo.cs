using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class KemOtherInfo : Asn1Encodable
{
	private static readonly PkiFreeText DEFAULT_staticString;

	private readonly PkiFreeText m_staticString;

	private readonly Asn1OctetString m_transactionID;

	private readonly Asn1OctetString m_senderNonce;

	private readonly Asn1OctetString m_recipNonce;

	private readonly DerInteger m_len;

	private readonly AlgorithmIdentifier m_mac;

	private readonly Asn1OctetString m_ct;

	public virtual Asn1OctetString TransactionID => null;

	public virtual Asn1OctetString SenderNonce => null;

	public virtual Asn1OctetString RecipNonce => null;

	public virtual DerInteger Len => null;

	public virtual AlgorithmIdentifier Mac => null;

	public virtual Asn1OctetString Ct => null;

	public static KemOtherInfo GetInstance(object obj)
	{
		return null;
	}

	public static KemOtherInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public KemOtherInfo(Asn1OctetString transactionID, Asn1OctetString senderNonce, Asn1OctetString recipNonce, DerInteger len, AlgorithmIdentifier mac, Asn1OctetString ct)
	{
	}

	public KemOtherInfo(Asn1OctetString transactionID, Asn1OctetString senderNonce, Asn1OctetString recipNonce, long len, AlgorithmIdentifier mac, Asn1OctetString ct)
	{
	}

	private KemOtherInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
