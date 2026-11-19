using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Utilities;

internal class SshBuffer
{
	private readonly byte[] buffer;

	private int pos;

	internal SshBuffer(byte[] magic, byte[] buffer)
	{
	}

	internal SshBuffer(byte[] buffer)
	{
	}

	public int ReadU32()
	{
		return 0;
	}

	public string ReadStringAscii()
	{
		return null;
	}

	public string ReadStringUtf8()
	{
		return null;
	}

	public byte[] ReadBlock()
	{
		return null;
	}

	public void SkipBlock()
	{
	}

	public byte[] ReadPaddedBlock()
	{
		return null;
	}

	public byte[] ReadPaddedBlock(int blockSize)
	{
		return null;
	}

	public BigInteger ReadMpint()
	{
		return null;
	}

	public BigInteger ReadMpintPositive()
	{
		return null;
	}

	public bool HasRemaining()
	{
		return false;
	}
}
