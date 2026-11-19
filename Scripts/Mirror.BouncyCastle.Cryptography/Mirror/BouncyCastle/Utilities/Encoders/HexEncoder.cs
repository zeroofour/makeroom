using System.IO;

namespace Mirror.BouncyCastle.Utilities.Encoders;

public class HexEncoder : IEncoder
{
	private static readonly char[] CharsLower;

	private static readonly char[] CharsUpper;

	protected readonly byte[] encodingTable;

	protected readonly byte[] decodingTable;

	protected void InitialiseDecodingTable()
	{
	}

	public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
	{
		return 0;
	}

	public int Encode(byte[] buf, int off, int len, Stream outStream)
	{
		return 0;
	}

	private static bool Ignore(char c)
	{
		return false;
	}

	public int Decode(byte[] data, int off, int length, Stream outStream)
	{
		return 0;
	}

	public int DecodeString(string data, Stream outStream)
	{
		return 0;
	}

	internal byte[] DecodeStrict(string str, int off, int len)
	{
		return null;
	}
}
