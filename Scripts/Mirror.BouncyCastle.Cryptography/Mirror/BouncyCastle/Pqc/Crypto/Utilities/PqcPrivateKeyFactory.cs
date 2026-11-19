using System.IO;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Utilities;

public static class PqcPrivateKeyFactory
{
	public static AsymmetricKeyParameter CreateKey(byte[] privateKeyInfoData)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(PrivateKeyInfo keyInfo)
	{
		return null;
	}
}
