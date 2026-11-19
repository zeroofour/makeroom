using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class MessageImprint : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_hashAlgorithm;

	private readonly byte[] m_hashedMessage;

	public AlgorithmIdentifier HashAlgorithm => null;

	public static MessageImprint GetInstance(object obj)
	{
		return null;
	}

	public static MessageImprint GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private MessageImprint(Asn1Sequence seq)
	{
	}

	public MessageImprint(AlgorithmIdentifier hashAlgorithm, byte[] hashedMessage)
	{
	}

	public byte[] GetHashedMessage()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
