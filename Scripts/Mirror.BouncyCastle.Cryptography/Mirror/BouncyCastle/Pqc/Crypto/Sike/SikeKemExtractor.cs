using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public sealed class SikeKemExtractor : IEncapsulatedSecretExtractor
{
	private readonly SikeKeyParameters key;

	private SikeEngine engine;

	public int EncapsulationLength => 0;

	public SikeKemExtractor(SikePrivateKeyParameters privParams)
	{
	}

	private void InitCipher(SikeParameters param)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}

	public byte[] ExtractSecret(byte[] encapsulation, int sessionKeySizeInBits)
	{
		return null;
	}
}
