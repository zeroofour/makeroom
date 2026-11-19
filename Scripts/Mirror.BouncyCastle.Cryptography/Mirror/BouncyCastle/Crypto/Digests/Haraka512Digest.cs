namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class Haraka512Digest : HarakaBase
{
	private readonly byte[] m_buf;

	private int m_bufPos;

	public override string AlgorithmName => null;

	public override int GetByteLength()
	{
		return 0;
	}

	public override void Update(byte input)
	{
	}

	public override void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public override void Reset()
	{
	}

	private static int Haraka512256(byte[] msg, byte[] output, int outOff)
	{
		return 0;
	}

	private static void Mix512(byte[][] s1, byte[][] s2)
	{
	}
}
