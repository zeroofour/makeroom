using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public class NtruKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private NtruKeyGenerationParameters _keygenParameters;

	private SecureRandom _random;

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
