using System.IO;

namespace Mirror.BouncyCastle.Asn1;

internal class DLBitStringParser : Asn1BitStringParser, IAsn1Convertible
{
	private readonly DefiniteLengthInputStream m_stream;

	private int m_padBits;

	public int PadBits => 0;

	internal DLBitStringParser(DefiniteLengthInputStream stream)
	{
	}

	public Stream GetBitStream()
	{
		return null;
	}

	public Stream GetOctetStream()
	{
		return null;
	}

	public Asn1Object ToAsn1Object()
	{
		return null;
	}

	private Stream GetBitStream(bool octetAligned)
	{
		return null;
	}
}
