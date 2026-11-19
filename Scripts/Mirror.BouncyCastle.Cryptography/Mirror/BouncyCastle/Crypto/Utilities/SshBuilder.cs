using System.IO;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Utilities;

internal class SshBuilder
{
	private readonly MemoryStream bos;

	public void U32(uint value)
	{
	}

	public void WriteMpint(BigInteger n)
	{
	}

	public void WriteBlock(byte[] value)
	{
	}

	public void WriteBytes(byte[] value)
	{
	}

	public void WriteStringAscii(string str)
	{
	}

	public void WriteStringUtf8(string str)
	{
	}

	public byte[] GetBytes()
	{
		return null;
	}

	public byte[] GetPaddedBytes()
	{
		return null;
	}

	public byte[] GetPaddedBytes(int blockSize)
	{
		return null;
	}
}
