using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class DsaKeyGenerationParameters : KeyGenerationParameters
{
	private readonly DsaParameters parameters;

	public DsaParameters Parameters => null;

	public DsaKeyGenerationParameters(SecureRandom random, DsaParameters parameters)
		: base(null, 0)
	{
	}
}
