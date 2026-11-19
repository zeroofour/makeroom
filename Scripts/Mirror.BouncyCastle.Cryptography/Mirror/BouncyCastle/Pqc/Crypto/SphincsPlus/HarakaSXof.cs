namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal sealed class HarakaSXof : HarakaSBase
{
	public string AlgorithmName => null;

	public HarakaSXof(byte[] pkSeed)
	{
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public int OutputFinal(byte[] output, int outOff, int len)
	{
		return 0;
	}
}
