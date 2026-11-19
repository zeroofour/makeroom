namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class WotsPlus
{
	private SphincsPlusEngine engine;

	private uint w;

	internal WotsPlus(SphincsPlusEngine engine)
	{
	}

	internal void PKGen(byte[] skSeed, byte[] pkSeed, Adrs paramAdrs, byte[] output)
	{
	}

	private byte[] Chain(byte[] X, uint i, uint s, byte[] pkSeed, Adrs adrs)
	{
		return null;
	}

	internal byte[] Sign(byte[] M, byte[] skSeed, byte[] pkSeed, Adrs paramAdrs)
	{
		return null;
	}

	internal void BaseW(byte[] X, int XOff, uint w, uint[] output, int outOff, int outLen)
	{
	}

	internal void PKFromSig(byte[] sig, byte[] M, byte[] pkSeed, Adrs adrs, byte[] output)
	{
	}
}
