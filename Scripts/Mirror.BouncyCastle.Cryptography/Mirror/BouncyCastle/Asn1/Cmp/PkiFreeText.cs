namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PkiFreeText : Asn1Encodable
{
	private readonly Asn1Sequence m_strings;

	public virtual int Count => 0;

	public DerUtf8String this[int index] => null;

	public static PkiFreeText GetInstance(object obj)
	{
		return null;
	}

	public static PkiFreeText GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal PkiFreeText(Asn1Sequence seq)
	{
	}

	public PkiFreeText(DerUtf8String p)
	{
	}

	public PkiFreeText(string p)
	{
	}

	public PkiFreeText(DerUtf8String[] strs)
	{
	}

	public PkiFreeText(string[] strs)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
