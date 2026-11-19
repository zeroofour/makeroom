using System.IO;

namespace Mirror.BouncyCastle.Asn1;

internal class IndefiniteLengthInputStream : LimitedInputStream
{
	private int _lookAhead;

	private bool _eofOn00;

	internal IndefiniteLengthInputStream(Stream inStream, int limit)
		: base(null, 0)
	{
	}

	internal void SetEofOn00(bool eofOn00)
	{
	}

	private void CheckEndOfContents()
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

	private int RequireByte()
	{
		return 0;
	}
}
