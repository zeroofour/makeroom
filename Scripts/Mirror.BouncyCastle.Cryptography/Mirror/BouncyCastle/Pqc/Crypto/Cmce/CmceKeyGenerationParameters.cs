using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmceKeyGenerationParameters : KeyGenerationParameters
{
	private CmceParameters parameters;

	public CmceParameters Parameters => null;

	public CmceKeyGenerationParameters(SecureRandom random, CmceParameters CmceParams)
		: base(null, 0)
	{
	}
}
