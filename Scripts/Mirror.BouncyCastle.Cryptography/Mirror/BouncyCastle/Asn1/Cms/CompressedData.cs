using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class CompressedData : Asn1Encodable
{
	private DerInteger version;

	private AlgorithmIdentifier compressionAlgorithm;

	private ContentInfo encapContentInfo;

	public DerInteger Version => null;

	public AlgorithmIdentifier CompressionAlgorithmIdentifier => null;

	public ContentInfo EncapContentInfo => null;

	public static CompressedData GetInstance(object obj)
	{
		return null;
	}

	public static CompressedData GetInstance(Asn1TaggedObject ato, bool explicitly)
	{
		return null;
	}

	public CompressedData(AlgorithmIdentifier compressionAlgorithm, ContentInfo encapContentInfo)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public CompressedData(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
