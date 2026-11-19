namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class Fors
{
	private readonly SphincsPlusEngine engine;

	internal Fors(SphincsPlusEngine engine)
	{
	}

	internal byte[] TreeHash(byte[] skSeed, uint s, int z, byte[] pkSeed, Adrs adrsParam)
	{
		return null;
	}

	internal SIG_FORS[] Sign(byte[] md, byte[] skSeed, byte[] pkSeed, Adrs paramAdrs)
	{
		return null;
	}

	internal byte[] PKFromSig(SIG_FORS[] sig_fors, byte[] message, byte[] pkSeed, Adrs adrs)
	{
		return null;
	}

	private static uint GetMessageIdx(byte[] msg, int fors_tree, int fors_height)
	{
		return 0u;
	}
}
