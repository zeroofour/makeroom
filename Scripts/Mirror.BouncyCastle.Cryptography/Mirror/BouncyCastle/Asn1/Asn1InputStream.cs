using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1InputStream : FilterStream
{
	private readonly int limit;

	private readonly bool m_leaveOpen;

	internal byte[][] tmpBuffers;

	internal static int FindLimit(Stream input)
	{
		return 0;
	}

	public Asn1InputStream(byte[] input)
		: base(null)
	{
	}

	public Asn1InputStream(Stream input)
		: base(null)
	{
	}

	public Asn1InputStream(Stream input, int limit)
		: base(null)
	{
	}

	public Asn1InputStream(Stream input, int limit, bool leaveOpen)
		: base(null)
	{
	}

	internal Asn1InputStream(Stream input, int limit, bool leaveOpen, byte[][] tmpBuffers)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private Asn1Object BuildObject(int tagHdr, int tagNo, int length)
	{
		return null;
	}

	internal Asn1Object ReadTaggedObjectDL(int tagClass, int tagNo, bool constructed, DefiniteLengthInputStream defIn)
	{
		return null;
	}

	private Asn1EncodableVector ReadVector()
	{
		return null;
	}

	private Asn1EncodableVector ReadVector(DefiniteLengthInputStream defIn)
	{
		return null;
	}

	public Asn1Object ReadObject()
	{
		return null;
	}

	private DerBitString BuildConstructedBitString(Asn1EncodableVector contentsElements)
	{
		return null;
	}

	private Asn1OctetString BuildConstructedOctetString(Asn1EncodableVector contentsElements)
	{
		return null;
	}

	internal static int ReadTagNumber(Stream s, int tagHdr)
	{
		return 0;
	}

	internal static int ReadLength(Stream s, int limit, bool isParsing)
	{
		return 0;
	}

	private static bool GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers, out byte[] contents)
	{
		contents = null;
		return false;
	}

	internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		return null;
	}

	private static DerBmpString CreateDerBmpString(DefiniteLengthInputStream defIn)
	{
		return null;
	}
}
