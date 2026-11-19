namespace Mirror.BouncyCastle.Asn1;

public class DerVideotexString : DerStringBase
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

	public static DerVideotexString GetInstance(object obj)
	{
		return null;
	}

	public static DerVideotexString GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerVideotexString(byte[] contents)
	{
	}

	internal DerVideotexString(byte[] contents, bool clone)
	{
	}

	public override string GetString()
	{
		return null;
	}

	public byte[] GetOctets()
	{
		return null;
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

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	internal static DerVideotexString CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
