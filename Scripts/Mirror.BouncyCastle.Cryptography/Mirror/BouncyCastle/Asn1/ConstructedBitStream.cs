using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

internal class ConstructedBitStream : BaseInputStream
{
	private readonly Asn1StreamParser m_parser;

	private readonly bool m_octetAligned;

	private bool m_first;

	private int m_padBits;

	private Asn1BitStringParser m_currentParser;

	private Stream m_currentStream;

	internal int PadBits => 0;

	internal ConstructedBitStream(Asn1StreamParser parser, bool octetAligned)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	private Asn1BitStringParser GetNextParser()
	{
		return null;
	}
}
