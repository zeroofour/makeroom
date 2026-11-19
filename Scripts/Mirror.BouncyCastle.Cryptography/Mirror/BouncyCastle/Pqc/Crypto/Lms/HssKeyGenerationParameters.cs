using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class HssKeyGenerationParameters : KeyGenerationParameters
{
	private readonly LmsParameters[] m_lmsParameters;

	public int Depth => 0;

	private static LmsParameters[] ValidateLmsParameters(LmsParameters[] lmsParameters)
	{
		return null;
	}

	public HssKeyGenerationParameters(LmsParameters[] lmsParameters, SecureRandom random)
		: base(null, 0)
	{
	}

	public LmsParameters GetLmsParameters(int index)
	{
		return null;
	}
}
