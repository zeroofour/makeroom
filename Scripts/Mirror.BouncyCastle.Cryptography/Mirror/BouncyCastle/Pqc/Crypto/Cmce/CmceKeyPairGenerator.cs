using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmceKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private CmceKeyGenerationParameters m_cmceParams;

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
