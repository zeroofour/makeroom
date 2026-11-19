namespace Mirror.BouncyCastle.Asn1;

public class DerUtf8String : DerStringBase
{
	internal class Meta : Asn1UniversalType
	{
		internal static readonly Asn1UniversalType Instance;

		private Meta()
			: base(null, 0)
		{
		}

		internal override Asn1Object FromImplicitPrimitive(DerOctetString octetString)
		{
			return null;
		}
	}

	private readonly byte[] m_contents;

	public static DerUtf8String GetInstance(object obj)
	{
		return null;
	}

	public static DerUtf8String GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerUtf8String(string str)
	{
	}

	public DerUtf8String(byte[] contents)
	{
	}

	internal DerUtf8String(byte[] contents, bool clone)
	{
	}

	public override string GetString()
	{
		return null;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	internal override IAsn1Encoding GetEncoding(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
	{
		return null;
	}

	internal static DerUtf8String CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
