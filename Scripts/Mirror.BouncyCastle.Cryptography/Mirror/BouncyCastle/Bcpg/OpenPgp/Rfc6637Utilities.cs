using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public sealed class Rfc6637Utilities
{
	private static readonly byte[] ANONYMOUS_SENDER;

	private Rfc6637Utilities()
	{
	}

	public static string GetAgreementAlgorithm(PublicKeyPacket pubKeyData)
	{
		return null;
	}

	public static DerObjectIdentifier GetKeyEncryptionOID(SymmetricKeyAlgorithmTag algID)
	{
		return null;
	}

	public static int GetKeyLength(SymmetricKeyAlgorithmTag algID)
	{
		return 0;
	}

	public static byte[] CreateKey(PublicKeyPacket pubKeyData, ECPoint s)
	{
		return null;
	}

	public static byte[] CreateKey(PublicKeyPacket pubKeyData, byte[] secret)
	{
		return null;
	}

	public static byte[] CreateUserKeyingMaterial(PublicKeyPacket pubKeyData)
	{
		return null;
	}

	private static byte[] Kdf(HashAlgorithmTag digestAlg, byte[] ZB, int keyLen, byte[] parameters)
	{
		return null;
	}
}
