namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconRNG
{
	private byte[] bd;

	private byte[] sd;

	private int ptr;

	private FalconConversions convertor;

	internal FalconRNG()
	{
	}

	internal void prng_init(SHAKE256 src)
	{
	}

	private void QROUND(uint[] state, int a, int b, int c, int d)
	{
	}

	private void prng_refill()
	{
	}

	internal void prng_get_bytes(byte[] dstsrc, int dst, int len)
	{
	}

	internal ulong prng_get_u64()
	{
		return 0uL;
	}

	internal uint prng_get_u8()
	{
		return 0u;
	}
}
