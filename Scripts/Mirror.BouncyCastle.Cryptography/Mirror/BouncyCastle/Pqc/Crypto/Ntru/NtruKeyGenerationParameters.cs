using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public class NtruKeyGenerationParameters : KeyGenerationParameters
{
	internal NtruParameters NtruParameters { get; }

	public NtruKeyGenerationParameters(SecureRandom random, NtruParameters ntruParameters)
		: base(null, 0)
	{
	}

	public NtruParameters GetParameters()
	{
		return null;
	}
}
