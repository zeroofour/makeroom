using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public sealed class SikeKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SikeKeyGenerationParameters sikeParams;

	private SecureRandom random;

	private void Initialize(KeyGenerationParameters param)
	{
	}

	private AsymmetricCipherKeyPair GenKeyPair()
	{
		return null;
	}

	public void Init(KeyGenerationParameters param)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
