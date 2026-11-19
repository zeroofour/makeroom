using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Tls;

public static class TlsRsaKeyExchange
{
	public const int PreMasterSecretLength = 48;

	public static byte[] DecryptPreMasterSecret(byte[] buf, int off, int len, RsaKeyParameters privateKey, int protocolVersion, SecureRandom secureRandom)
	{
		return null;
	}

	public static int GetInputLimit(RsaKeyParameters privateKey)
	{
		return 0;
	}

	private static int CAddTo(int len, int cond, byte[] x, byte[] z)
	{
		return 0;
	}

	private static int CheckPkcs1Encoding2(byte[] buf, int pkcs1Length, int plaintextLength)
	{
		return 0;
	}

	private static BigInteger ConvertInput(BigInteger modulus, byte[] buf, int off, int len)
	{
		return null;
	}

	private static BigInteger Rsa(RsaKeyParameters privateKey, BigInteger input)
	{
		return null;
	}

	private static byte[] RsaBlinded(RsaKeyParameters privateKey, BigInteger input, SecureRandom secureRandom)
	{
		return null;
	}

	private static BigInteger RsaCrt(RsaPrivateCrtKeyParameters crtKey, BigInteger input)
	{
		return null;
	}

	private static int SubFrom(int len, byte[] x, byte[] z)
	{
		return 0;
	}
}
