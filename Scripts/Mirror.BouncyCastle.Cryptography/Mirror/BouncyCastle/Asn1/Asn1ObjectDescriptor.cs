namespace Mirror.BouncyCastle.Asn1;

public sealed class Asn1ObjectDescriptor : Asn1Object
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

		internal override Asn1Object FromImplicitConstructed(Asn1Sequence sequence)
		{
			return null;
		}
	}

	private readonly DerGraphicString m_baseGraphicString;

	public DerGraphicString BaseGraphicString => null;

	public static Asn1ObjectDescriptor GetInstance(object obj)
	{
		return null;
	}

	public static Asn1ObjectDescriptor GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public Asn1ObjectDescriptor(DerGraphicString baseGraphicString)
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

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	internal static Asn1ObjectDescriptor CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
