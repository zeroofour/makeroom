using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1;

public class DerInteger : Asn1Object
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

	public const string AllowUnsafeProperty = "Mirror.BouncyCastle.Asn1.AllowUnsafeInteger";

	internal const int SignExtSigned = -1;

	internal const int SignExtUnsigned = 255;

	private readonly byte[] bytes;

	private readonly int start;

	public BigInteger PositiveValue => null;

	public BigInteger Value => null;

	public int IntPositiveValueExact => 0;

	public int IntValueExact => 0;

	public long LongValueExact => 0L;

	internal static bool AllowUnsafe()
	{
		return false;
	}

	public static DerInteger GetInstance(object obj)
	{
		return null;
	}

	public static DerInteger GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerInteger(int value)
	{
	}

	public DerInteger(long value)
	{
	}

	public DerInteger(BigInteger value)
	{
	}

	public DerInteger(byte[] bytes)
	{
	}

	internal DerInteger(byte[] bytes, bool clone)
	{
	}

	public bool HasValue(int x)
	{
		return false;
	}

	public bool HasValue(long x)
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

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	internal static DerInteger CreatePrimitive(byte[] contents)
	{
		return null;
	}

	internal static int GetEncodingLength(BigInteger x)
	{
		return 0;
	}

	internal static int IntValue(byte[] bytes, int start, int signExt)
	{
		return 0;
	}

	internal static long LongValue(byte[] bytes, int start, int signExt)
	{
		return 0L;
	}

	internal static bool IsMalformed(byte[] bytes)
	{
		return false;
	}

	internal static int SignBytesToSkip(byte[] bytes)
	{
		return 0;
	}
}
