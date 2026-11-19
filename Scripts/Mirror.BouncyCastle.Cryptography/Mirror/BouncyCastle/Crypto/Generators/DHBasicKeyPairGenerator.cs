using System;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Generators;

[Obsolete("Use 'DHKeyPairGenerator' instead")]
public class DHBasicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private DHKeyGenerationParameters m_parameters;

	public virtual void Init(KeyGenerationParameters parameters)
	{
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}
}
