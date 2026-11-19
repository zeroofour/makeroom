namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

internal sealed class HqcKeccakRandomGenerator
{
	private static readonly ulong[] KeccakRoundConstants;

	private readonly ulong[] state;

	private readonly byte[] dataQueue;

	private int rate;

	private int fixedOutputLength;

	public HqcKeccakRandomGenerator()
	{
	}

	public HqcKeccakRandomGenerator(int bitLength)
	{
	}

	private void Init(int bitLength)
	{
	}

	private void InitSponge(int rate)
	{
	}

	private void KeccakIncAbsorb(byte[] input, int inputLen)
	{
	}

	private void KeccakIncFinalize(int p)
	{
	}

	private void KeccakIncSqueeze(byte[] output, int outLen)
	{
	}

	public void Squeeze(byte[] output, int outLen)
	{
	}

	public void RandomGeneratorInit(byte[] entropyInput, byte[] personalizationString, int entropyLen, int perLen)
	{
	}

	public void SeedExpanderInit(byte[] seed, int seedLen)
	{
	}

	public void ExpandSeed(byte[] output, int outLen)
	{
	}

	public void SHAKE256_512_ds(byte[] output, byte[] input, int inLen, byte[] domain)
	{
	}
}
