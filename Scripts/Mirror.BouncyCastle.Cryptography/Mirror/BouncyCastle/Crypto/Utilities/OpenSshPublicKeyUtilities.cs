namespace Mirror.BouncyCastle.Crypto.Utilities;

public static class OpenSshPublicKeyUtilities
{
	private static readonly string RSA;

	private static readonly string ECDSA;

	private static readonly string ED_25519;

	private static readonly string DSS;

	public static AsymmetricKeyParameter ParsePublicKey(byte[] encoded)
	{
		return null;
	}

	public static byte[] EncodePublicKey(AsymmetricKeyParameter cipherParameters)
	{
		return null;
	}

	private static AsymmetricKeyParameter ParsePublicKey(SshBuffer buffer)
	{
		return null;
	}
}
