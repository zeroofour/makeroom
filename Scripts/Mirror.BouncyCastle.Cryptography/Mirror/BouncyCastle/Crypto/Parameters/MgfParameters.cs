namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class MgfParameters : IDerivationParameters
{
	private readonly byte[] m_seed;

	public int SeedLength => 0;

	public MgfParameters(byte[] seed)
	{
	}

	public MgfParameters(byte[] seed, int off, int len)
	{
	}

	public byte[] GetSeed()
	{
		return null;
	}

	public void GetSeed(byte[] buffer, int offset)
	{
	}
}
