using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public class PicnicKeyGenerationParameters : KeyGenerationParameters
{
	private readonly PicnicParameters m_parameters;

	public PicnicParameters Parameters => null;

	public PicnicKeyGenerationParameters(SecureRandom random, PicnicParameters parameters)
		: base(null, 0)
	{
	}
}
