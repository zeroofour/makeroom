using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Pkcs;

public static class PrivateKeyInfoFactory
{
	public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey)
	{
		return null;
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey, Asn1Set attributes)
	{
		return null;
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
	{
		return null;
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, bool wrongPkcs12Zero, EncryptedPrivateKeyInfo encInfo)
	{
		return null;
	}

	private static void ExtractBytes(byte[] encKey, int size, int offSet, BigInteger bI)
	{
	}
}
