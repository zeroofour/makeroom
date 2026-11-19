using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1;

public class DerEnumerated : Asn1Object
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

	private readonly byte[] contents;

	private readonly int start;

	private static readonly DerEnumerated[] cache;

	public BigInteger Value => null;

	public int IntValueExact => 0;

	public static DerEnumerated GetInstance(object obj)
	{
		return null;
	}

	public static DerEnumerated GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerEnumerated(int val)
	{
	}

	public DerEnumerated(long val)
	{
	}

	public DerEnumerated(BigInteger val)
	{
	}

	public DerEnumerated(byte[] contents)
	{
	}

	internal DerEnumerated(byte[] contents, bool clone)
	{
	}

	public bool HasValue(int x)
	{
		return false;
	}

	public bool HasValue(BigInteger x)
	{
		return false;
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

	internal static DerEnumerated CreatePrimitive(byte[] contents, bool clone)
	{
		return null;
	}
}
