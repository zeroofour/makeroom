using System.IO;

namespace Mirror.BouncyCastle.Asn1;

internal class BerBitStringParser : Asn1BitStringParser, IAsn1Convertible
{
	private readonly Asn1StreamParser m_parser;

	private ConstructedBitStream m_bitStream;

	public int PadBits => 0;

	internal BerBitStringParser(Asn1StreamParser parser)
	{
	}

	public Stream GetOctetStream()
	{
		return null;
	}

	public Stream GetBitStream()
	{
		return null;
	}

	public Asn1Object ToAsn1Object()
	{
		return null;
	}

	internal static BerBitString Parse(Asn1StreamParser sp)
	{
		return null;
	}
}
