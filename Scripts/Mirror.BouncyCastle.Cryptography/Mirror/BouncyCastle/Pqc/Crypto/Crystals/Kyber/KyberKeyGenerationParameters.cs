using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberKeyGenerationParameters : KeyGenerationParameters
{
	private readonly KyberParameters m_parameters;

	public KyberParameters Parameters => null;

	public KyberKeyGenerationParameters(SecureRandom random, KyberParameters KyberParameters)
		: base(null, 0)
	{
	}
}
