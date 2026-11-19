using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public class DerBitString : DerStringBase, Asn1BitStringParser, IAsn1Convertible
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

	private static readonly char[] table;

	internal readonly byte[] contents;

	public virtual int PadBits => 0;

	public virtual int IntValue => 0;

	public Asn1BitStringParser Parser => null;

	public static DerBitString GetInstance(object obj)
	{
		return null;
	}

	public static DerBitString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	public DerBitString(byte data, int padBits)
	{
	}

	public DerBitString(byte[] data)
	{
	}

	public DerBitString(byte[] data, int padBits)
	{
	}

	public DerBitString(int namedBits)
	{
	}

	public DerBitString(Asn1Encodable obj)
	{
	}

	internal DerBitString(byte[] contents, bool check)
	{
	}

	public virtual byte[] GetOctets()
	{
		return null;
	}

	public virtual byte[] GetBytes()
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

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	public Stream GetBitStream()
	{
		return null;
	}

	public Stream GetOctetStream()
	{
		return null;
	}

	public override string GetString()
	{
		return null;
	}

	internal static DerBitString CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
