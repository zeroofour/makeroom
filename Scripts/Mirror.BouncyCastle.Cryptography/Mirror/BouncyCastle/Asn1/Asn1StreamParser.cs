using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1StreamParser
{
	private readonly Stream _in;

	private readonly int _limit;

	private readonly byte[][] tmpBuffers;

	public Asn1StreamParser(Stream input)
	{
	}

	public Asn1StreamParser(byte[] encoding)
	{
	}

	public Asn1StreamParser(Stream input, int limit)
	{
	}

	internal Asn1StreamParser(Stream input, int limit, byte[][] tmpBuffers)
	{
	}

	public virtual IAsn1Convertible ReadObject()
	{
		return null;
	}

	internal IAsn1Convertible ImplParseObject(int tagHdr)
	{
		return null;
	}

	internal Asn1Object LoadTaggedDL(int tagClass, int tagNo, bool constructed)
	{
		return null;
	}

	internal Asn1Object LoadTaggedIL(int tagClass, int tagNo)
	{
		return null;
	}

	internal IAsn1Convertible ParseImplicitConstructedDL(int univTagNo)
	{
		return null;
	}

	internal IAsn1Convertible ParseImplicitConstructedIL(int univTagNo)
	{
		return null;
	}

	internal IAsn1Convertible ParseImplicitPrimitive(int univTagNo)
	{
		return null;
	}

	internal IAsn1Convertible ParseImplicitPrimitive(int univTagNo, DefiniteLengthInputStream defIn)
	{
		return null;
	}

	internal IAsn1Convertible ParseObject(int univTagNo)
	{
		return null;
	}

	internal Asn1TaggedObjectParser ParseTaggedObject()
	{
		return null;
	}

	internal Asn1EncodableVector ReadVector()
	{
		return null;
	}

	private void Set00Check(bool enabled)
	{
	}
}
