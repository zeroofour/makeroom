namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class HT
{
	private byte[] skSeed;

	private byte[] pkSeed;

	private SphincsPlusEngine engine;

	private WotsPlus wots;

	internal byte[] HTPubKey;

	internal HT(SphincsPlusEngine engine, byte[] skSeed, byte[] pkSeed)
	{
	}

	internal byte[] Sign(byte[] M, ulong idx_tree, uint idx_leaf)
	{
		return null;
	}

	private byte[] xmss_PKgen(byte[] skSeed, byte[] pkSeed, Adrs adrs)
	{
		return null;
	}

	private byte[] xmss_pkFromSig(uint idx, SIG_XMSS sig_xmss, byte[] M, byte[] pkSeed, Adrs paramAdrs)
	{
		return null;
	}

	private SIG_XMSS xmss_sign(byte[] M, byte[] skSeed, uint idx, byte[] pkSeed, Adrs paramAdrs)
	{
		return null;
	}

	private byte[] TreeHash(byte[] skSeed, uint s, uint z, byte[] pkSeed, Adrs adrsParam)
	{
		return null;
	}

	internal bool Verify(byte[] M, SIG_XMSS[] sig_ht, byte[] pkSeed, ulong idx_tree, uint idx_leaf, byte[] PK_HT)
	{
		return false;
	}
}
