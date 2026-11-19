using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public static class SubjectPublicKeyInfoFactory
{
	public static SubjectPublicKeyInfo CreateSubjectPublicKeyInfo(AsymmetricKeyParameter publicKey)
	{
		return null;
	}

	private static void ExtractBytes(byte[] encKey, int offset, BigInteger bI)
	{
	}

	private static void ExtractBytes(byte[] encKey, int size, int offSet, BigInteger bI)
	{
	}
}
