using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.IO.Pem;

namespace Mirror.BouncyCastle.OpenSsl;

public class MiscPemGenerator : PemObjectGenerator
{
	private readonly object obj;

	private readonly string algorithm;

	private readonly char[] password;

	private readonly SecureRandom random;

	public MiscPemGenerator(object obj)
	{
	}

	public MiscPemGenerator(object obj, string algorithm, char[] password, SecureRandom random)
	{
	}

	private static PemObject CreatePemObject(object obj)
	{
		return null;
	}

	private static PemObject CreatePemObject(object obj, string algorithm, char[] password, SecureRandom random)
	{
		return null;
	}

	public PemObject Generate()
	{
		return null;
	}

	private static byte[] EncodePrivateKey(AsymmetricKeyParameter akp, out string keyType)
	{
		keyType = null;
		return null;
	}

	private static byte[] EncodePrivateKeyInfo(PrivateKeyInfo info, out string keyType)
	{
		keyType = null;
		return null;
	}

	private static byte[] EncodePublicKey(AsymmetricKeyParameter akp, out string keyType)
	{
		keyType = null;
		return null;
	}

	private static byte[] EncodePublicKeyInfo(SubjectPublicKeyInfo info, out string keyType)
	{
		keyType = null;
		return null;
	}
}
