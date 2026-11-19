namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal sealed class HarakaS512Digest : HarakaSBase
{
	public string AlgorithmName => null;

	public HarakaS512Digest(HarakaSBase harakaSBase)
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
