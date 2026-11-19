using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pkcs;

public sealed class EncryptedPrivateKeyInfoFactory
{
	private EncryptedPrivateKeyInfoFactory()
	{
	}

	public static EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return null;
	}

	public static EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return null;
	}

	public static EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, PrivateKeyInfo keyInfo)
	{
		return null;
	}

	public static EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(DerObjectIdentifier cipherAlgorithm, DerObjectIdentifier prfAlgorithm, char[] passPhrase, byte[] salt, int iterationCount, SecureRandom random, AsymmetricKeyParameter key)
	{
		return null;
	}

	public static EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(DerObjectIdentifier cipherAlgorithm, DerObjectIdentifier prfAlgorithm, char[] passPhrase, byte[] salt, int iterationCount, SecureRandom random, PrivateKeyInfo keyInfo)
	{
		return null;
	}
}
