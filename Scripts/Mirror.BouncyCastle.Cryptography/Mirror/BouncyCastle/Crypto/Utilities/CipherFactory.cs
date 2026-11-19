using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public class CipherFactory
{
	private static readonly byte[] RC2Ekb;

	private CipherFactory()
	{
	}

	public static object CreateContentCipher(bool forEncryption, ICipherParameters encKey, AlgorithmIdentifier encryptionAlgID)
	{
		return null;
	}

	private static BufferedBlockCipher CreateCipher(DerObjectIdentifier algorithm)
	{
		return null;
	}
}
