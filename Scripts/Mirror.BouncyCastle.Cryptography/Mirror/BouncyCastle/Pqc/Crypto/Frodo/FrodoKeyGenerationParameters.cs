using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public class FrodoKeyGenerationParameters : KeyGenerationParameters
{
	private readonly FrodoParameters m_parameters;

	public FrodoParameters Parameters => null;

	public FrodoKeyGenerationParameters(SecureRandom random, FrodoParameters frodoParameters)
		: base(null, 0)
	{
	}
}
