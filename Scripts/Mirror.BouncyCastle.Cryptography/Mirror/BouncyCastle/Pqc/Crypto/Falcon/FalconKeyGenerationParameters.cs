using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public class FalconKeyGenerationParameters : KeyGenerationParameters
{
	private FalconParameters parameters;

	public FalconParameters Parameters => null;

	public FalconKeyGenerationParameters(SecureRandom random, FalconParameters parameters)
		: base(null, 0)
	{
	}
}
