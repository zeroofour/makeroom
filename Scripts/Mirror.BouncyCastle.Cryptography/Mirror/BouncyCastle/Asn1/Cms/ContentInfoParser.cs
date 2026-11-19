namespace Mirror.BouncyCastle.Asn1.Cms;

public class ContentInfoParser
{
	private readonly DerObjectIdentifier m_contentType;

	private readonly Asn1TaggedObjectParser m_content;

	public DerObjectIdentifier ContentType => null;

	public ContentInfoParser(Asn1SequenceParser seq)
	{
	}

	public IAsn1Convertible GetContent(int tag)
	{
		return null;
	}
}
