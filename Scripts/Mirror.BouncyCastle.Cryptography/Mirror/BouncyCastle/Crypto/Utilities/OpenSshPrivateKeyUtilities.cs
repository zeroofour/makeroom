using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public static class OpenSshPrivateKeyUtilities
{
	private static readonly byte[] AUTH_MAGIC;

	public static byte[] EncodePrivateKey(AsymmetricKeyParameter parameters)
	{
		return null;
	}

	public static AsymmetricKeyParameter ParsePrivateKeyBlob(byte[] blob)
	{
		return null;
	}

	private static bool AllIntegers(Asn1Sequence sequence)
	{
		return false;
	}
}
