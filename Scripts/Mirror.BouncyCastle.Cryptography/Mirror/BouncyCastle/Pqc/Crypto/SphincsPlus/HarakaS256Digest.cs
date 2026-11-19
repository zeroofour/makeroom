namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal sealed class HarakaS256Digest : HarakaSBase
{
	public string AlgorithmName => null;

	public HarakaS256Digest(HarakaSXof harakaSXof)
	{
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}
}
