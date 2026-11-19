using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public sealed class SphincsPlusKeyGenerationParameters : KeyGenerationParameters
{
	private readonly SphincsPlusParameters m_parameters;

	public SphincsPlusParameters Parameters => null;

	public SphincsPlusKeyGenerationParameters(SecureRandom random, SphincsPlusParameters parameters)
		: base(null, 0)
	{
	}
}
