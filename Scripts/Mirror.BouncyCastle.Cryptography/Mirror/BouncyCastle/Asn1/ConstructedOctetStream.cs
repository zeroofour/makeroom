using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

internal class ConstructedOctetStream : BaseInputStream
{
	private readonly Asn1StreamParser m_parser;

	private bool m_first;

	private Stream m_currentStream;

	internal ConstructedOctetStream(Asn1StreamParser parser)
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

	private Asn1OctetStringParser GetNextParser()
	{
		return null;
	}
}
