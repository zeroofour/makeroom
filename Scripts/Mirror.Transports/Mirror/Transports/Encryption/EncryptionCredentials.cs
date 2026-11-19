using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.Transports.Encryption;

public class EncryptionCredentials
{
	private class SerializedPair
	{
		public string PublicKeyFingerprint;

		public string PublicKey;

		public string PrivateKey;
	}

	private const int PrivateKeyBits = 256;

	public byte[] PublicKeySerialized;

	public ECPrivateKeyParameters PrivateKey;

	public string PublicKeyFingerprint;

	private EncryptionCredentials()
	{
	}

	public static EncryptionCredentials Generate()
	{
		return null;
	}

	public static byte[] SerializePublicKey(AsymmetricKeyParameter publicKey)
	{
		return null;
	}

	public static AsymmetricKeyParameter DeserializePublicKey(ArraySegment<byte> pubKey)
	{
		return null;
	}

	public static byte[] SerializePrivateKey(AsymmetricKeyParameter privateKey)
	{
		return null;
	}

	public static AsymmetricKeyParameter DeserializePrivateKey(ArraySegment<byte> privateKey)
	{
		return null;
	}

	public static string PubKeyFingerprint(ArraySegment<byte> publicKeyBytes)
	{
		return null;
	}

	public void SaveToFile(string path)
	{
	}

	public static EncryptionCredentials LoadFromFile(string path)
	{
		return null;
	}
}
