namespace Mirror.BouncyCastle.Crypto.Prng;

public sealed class VmpcRandomGenerator : IRandomGenerator
{
	private readonly byte[] P;

	private byte s;

	private byte n;

	public void AddSeedMaterial(byte[] seed)
	{
	}

	public void AddSeedMaterial(long seed)
	{
	}

	public void NextBytes(byte[] bytes)
	{
	}

	public void NextBytes(byte[] bytes, int start, int len)
	{
	}
}
