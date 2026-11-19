using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public static class CipherKeyGeneratorFactory
{
	public static CipherKeyGenerator CreateKeyGenerator(DerObjectIdentifier algorithm, SecureRandom random)
	{
		return null;
	}

	private static CipherKeyGenerator CreateCipherKeyGenerator(SecureRandom random, int keySize)
	{
		return null;
	}
}
