using System;

namespace Mirror.BouncyCastle.Asn1.X509;

public class SubjectPublicKeyInfo : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_algorithm;

	private readonly DerBitString m_publicKey;

	public AlgorithmIdentifier Algorithm => null;

	[Obsolete("Use 'Algorithm' instead")]
	public AlgorithmIdentifier AlgorithmID => null;

	public DerBitString PublicKey => null;

	[Obsolete("Use 'PublicKey' instead")]
	public DerBitString PublicKeyData => null;

	public static SubjectPublicKeyInfo GetInstance(object obj)
	{
		return null;
	}

	public static SubjectPublicKeyInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public SubjectPublicKeyInfo(AlgorithmIdentifier algID, DerBitString publicKey)
	{
	}

	public SubjectPublicKeyInfo(AlgorithmIdentifier algID, Asn1Encodable publicKey)
	{
	}

	public SubjectPublicKeyInfo(AlgorithmIdentifier algID, byte[] publicKey)
	{
	}

	private SubjectPublicKeyInfo(Asn1Sequence seq)
	{
	}

	public Asn1Object ParsePublicKey()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
