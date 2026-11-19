namespace Mirror.BouncyCastle.Asn1;

public class DerIA5String : DerStringBase
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

	public static DerIA5String GetInstance(object obj)
	{
		return null;
	}

	public static DerIA5String GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerIA5String(string str)
	{
	}

	public DerIA5String(string str, bool validate)
	{
	}

	public DerIA5String(byte[] contents)
	{
	}

	internal DerIA5String(byte[] contents, bool clone)
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

	public static bool IsIA5String(string str)
	{
		return false;
	}

	internal static DerIA5String CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
