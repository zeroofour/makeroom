using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public class DilithiumKeyGenerationParameters : KeyGenerationParameters
{
	private DilithiumParameters parameters;

	public DilithiumParameters Parameters => null;

	public DilithiumKeyGenerationParameters(SecureRandom random, DilithiumParameters parameters)
		: base(null, 0)
	{
	}
}
