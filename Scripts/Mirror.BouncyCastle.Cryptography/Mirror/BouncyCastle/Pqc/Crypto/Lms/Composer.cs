using System.IO;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class Composer
{
	private readonly MemoryStream bos;

	private Composer()
	{
	}

	public static Composer Compose()
	{
		return null;
	}

	public Composer U64Str(long n)
	{
		return null;
	}

	public Composer U32Str(int n)
	{
		return null;
	}

	public Composer U16Str(int n)
	{
		return null;
	}

	public Composer Bytes(IEncodable[] encodable)
	{
		return null;
	}

	public Composer Bytes(IEncodable encodable)
	{
		return null;
	}

	public Composer Pad(int v, int len)
	{
		return null;
	}

	public Composer Bytes2(byte[][] arrays)
	{
		return null;
	}

	public Composer Bytes2(byte[][] arrays, int start, int end)
	{
		return null;
	}

	public Composer Bytes(byte[] array)
	{
		return null;
	}

	public Composer Bytes(byte[] array, int start, int len)
	{
		return null;
	}

	public byte[] Build()
	{
		return null;
	}

	public Composer PadUntil(int v, int requiredLen)
	{
		return null;
	}

	public Composer Boolean(bool v)
	{
		return null;
	}
}
