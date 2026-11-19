using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class EncryptedContentInfo : Asn1Encodable
{
	private DerObjectIdentifier contentType;

	private AlgorithmIdentifier contentEncryptionAlgorithm;

	private Asn1OctetString encryptedContent;

	public DerObjectIdentifier ContentType => null;

	public AlgorithmIdentifier ContentEncryptionAlgorithm => null;

	public Asn1OctetString EncryptedContent => null;

	public static EncryptedContentInfo GetInstance(object obj)
	{
		return null;
	}

	public static EncryptedContentInfo GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public EncryptedContentInfo(DerObjectIdentifier contentType, AlgorithmIdentifier contentEncryptionAlgorithm, Asn1OctetString encryptedContent)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public EncryptedContentInfo(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
