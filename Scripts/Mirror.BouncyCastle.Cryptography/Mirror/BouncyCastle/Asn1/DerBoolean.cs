namespace Mirror.BouncyCastle.Asn1;

public class DerBoolean : Asn1Object
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

	public static readonly DerBoolean False;

	public static readonly DerBoolean True;

	private readonly byte value;

	public bool IsTrue => false;

	public static DerBoolean GetInstance(object obj)
	{
		return null;
	}

	public static DerBoolean GetInstance(bool value)
	{
		return null;
	}

	public static DerBoolean GetInstance(int value)
	{
		return null;
	}

	public static DerBoolean GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerBoolean(byte[] val)
	{
	}

	private DerBoolean(bool value)
	{
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

	public override string ToString()
	{
		return null;
	}

	internal static DerBoolean CreatePrimitive(byte[] contents)
	{
		return null;
	}

	private byte[] GetContents(int encoding)
	{
		return null;
	}
}
