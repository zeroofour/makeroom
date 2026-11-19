using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class EncryptedContentInfoParser
{
	private readonly DerObjectIdentifier m_contentType;

	private readonly AlgorithmIdentifier m_contentEncryptionAlgorithm;

	private readonly Asn1TaggedObjectParser m_encryptedContent;

	public DerObjectIdentifier ContentType => null;

	public AlgorithmIdentifier ContentEncryptionAlgorithm => null;

	public EncryptedContentInfoParser(Asn1SequenceParser seq)
	{
	}

	public IAsn1Convertible GetEncryptedContent(int tag)
	{
		return null;
	}
}
