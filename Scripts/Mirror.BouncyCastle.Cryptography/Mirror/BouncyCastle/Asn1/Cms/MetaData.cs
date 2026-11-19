namespace Mirror.BouncyCastle.Asn1.Cms;

public class MetaData : Asn1Encodable
{
	private DerBoolean hashProtected;

	private DerUtf8String fileName;

	private DerIA5String mediaType;

	private Attributes otherMetaData;

	public virtual bool IsHashProtected => false;

	public virtual DerUtf8String FileName => null;

	public virtual DerIA5String MediaType => null;

	public virtual Attributes OtherMetaData => null;

	public static MetaData GetInstance(object obj)
	{
		return null;
	}

	public static MetaData GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public MetaData(DerBoolean hashProtected, DerUtf8String fileName, DerIA5String mediaType, Attributes otherMetaData)
	{
	}

	private MetaData(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
