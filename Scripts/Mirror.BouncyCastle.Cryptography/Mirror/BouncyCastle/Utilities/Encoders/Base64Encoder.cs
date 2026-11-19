using System.IO;

namespace Mirror.BouncyCastle.Utilities.Encoders;

public class Base64Encoder : IEncoder
{
	protected readonly byte[] encodingTable;

	protected byte padding;

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

	private bool Ignore(char c)
	{
		return false;
	}

	public int Decode(byte[] data, int off, int length, Stream outStream)
	{
		return 0;
	}

	private int NextI(byte[] data, int i, int finish)
	{
		return 0;
	}

	public int DecodeString(string data, Stream outStream)
	{
		return 0;
	}

	private int DecodeLastBlock(Stream outStream, char c1, char c2, char c3, char c4)
	{
		return 0;
	}

	private int NextI(string data, int i, int finish)
	{
		return 0;
	}
}
