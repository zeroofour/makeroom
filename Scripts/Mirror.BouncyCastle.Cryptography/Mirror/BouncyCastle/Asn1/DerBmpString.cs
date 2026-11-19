namespace Mirror.BouncyCastle.Asn1;

public class DerBmpString : DerStringBase
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

	private readonly string m_str;

	public static DerBmpString GetInstance(object obj)
	{
		return null;
	}

	public static DerBmpString GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal DerBmpString(byte[] contents)
	{
	}

	internal DerBmpString(char[] str)
	{
	}

	public DerBmpString(string str)
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

	private byte[] GetContents()
	{
		return null;
	}

	internal static DerBmpString CreatePrimitive(byte[] contents)
	{
		return null;
	}

	internal static DerBmpString CreatePrimitive(char[] str)
	{
		return null;
	}
}
