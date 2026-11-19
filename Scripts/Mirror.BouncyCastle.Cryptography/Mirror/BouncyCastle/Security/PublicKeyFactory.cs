using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Security;

public static class PublicKeyFactory
{
	public static AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo)
	{
		return null;
	}

	private static byte[] GetRawKey(SubjectPublicKeyInfo keyInfo)
	{
		return null;
	}

	private static bool IsPkcsDHParam(Asn1Sequence seq)
	{
		return false;
	}

	private static DHPublicKeyParameters ReadPkcsDHParam(DerObjectIdentifier algOid, BigInteger y, Asn1Sequence seq)
	{
		return null;
	}
}
