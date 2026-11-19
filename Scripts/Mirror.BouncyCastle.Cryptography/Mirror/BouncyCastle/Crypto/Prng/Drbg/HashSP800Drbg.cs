using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Prng.Drbg;

public sealed class HashSP800Drbg : ISP80090Drbg
{
	private static readonly byte[] ONE;

	private static readonly long RESEED_MAX;

	private static readonly int MAX_BITS_REQUEST;

	private static readonly IDictionary<string, int> SeedLens;

	private readonly IDigest mDigest;

	private readonly IEntropySource mEntropySource;

	private readonly int mSecurityStrength;

	private readonly int mSeedLength;

	private byte[] mV;

	private byte[] mC;

	private long mReseedCounter;

	public int BlockSize => 0;

	static HashSP800Drbg()
	{
	}

	public HashSP800Drbg(IDigest digest, int securityStrength, IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
	{
	}

	public int Generate(byte[] output, int outputOff, int outputLen, byte[] additionalInput, bool predictionResistant)
	{
		return 0;
	}

	private byte[] GetEntropy()
	{
		return null;
	}

	private void AddTo(byte[] longer, byte[] shorter)
	{
	}

	public void Reseed(byte[] additionalInput)
	{
	}

	private void DoHash(byte[] input, byte[] output)
	{
	}

	private byte[] Hash(byte[] input)
	{
		return null;
	}

	private byte[] Hashgen(byte[] input, int length)
	{
		return null;
	}
}
