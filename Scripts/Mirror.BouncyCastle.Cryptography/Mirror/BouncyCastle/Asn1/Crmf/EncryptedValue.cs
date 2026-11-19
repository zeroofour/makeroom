using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class EncryptedValue : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_intendedAlg;

	private readonly AlgorithmIdentifier m_symmAlg;

	private readonly DerBitString m_encSymmKey;

	private readonly AlgorithmIdentifier m_keyAlg;

	private readonly Asn1OctetString m_valueHint;

	private readonly DerBitString m_encValue;

	public virtual AlgorithmIdentifier IntendedAlg => null;

	public virtual AlgorithmIdentifier SymmAlg => null;

	public virtual DerBitString EncSymmKey => null;

	public virtual AlgorithmIdentifier KeyAlg => null;

	public virtual Asn1OctetString ValueHint => null;

	public virtual DerBitString EncValue => null;

	public static EncryptedValue GetInstance(object obj)
	{
		return null;
	}

	private EncryptedValue(Asn1Sequence seq)
	{
	}

	public EncryptedValue(AlgorithmIdentifier intendedAlg, AlgorithmIdentifier symmAlg, DerBitString encSymmKey, AlgorithmIdentifier keyAlg, Asn1OctetString valueHint, DerBitString encValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
