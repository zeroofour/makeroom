namespace Mirror.BouncyCastle.Asn1.Tsp;

public class PartialHashtree : Asn1Encodable
{
	private readonly Asn1Sequence m_values;

	public virtual int ValueCount => 0;

	public static PartialHashtree GetInstance(object obj)
	{
		return null;
	}

	public static PartialHashtree GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private PartialHashtree(Asn1Sequence values)
	{
	}

	public PartialHashtree(params byte[][] values)
	{
	}

	public virtual byte[][] GetValues()
	{
		return null;
	}

	public virtual bool ContainsHash(byte[] hash)
	{
		return false;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
