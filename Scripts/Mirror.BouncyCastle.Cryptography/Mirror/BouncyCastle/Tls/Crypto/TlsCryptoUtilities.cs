using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Tls.Crypto;

public abstract class TlsCryptoUtilities
{
	private static readonly byte[] Tls13Prefix;

	public static int GetHash(short hashAlgorithm)
	{
		return 0;
	}

	public static int GetHashForHmac(int macAlgorithm)
	{
		return 0;
	}

	public static int GetHashForPrf(int prfAlgorithm)
	{
		return 0;
	}

	public static int GetHashInternalSize(int cryptoHashAlgorithm)
	{
		return 0;
	}

	public static int GetHashOutputSize(int cryptoHashAlgorithm)
	{
		return 0;
	}

	public static DerObjectIdentifier GetOidForHash(int cryptoHashAlgorithm)
	{
		return null;
	}

	public static int GetSignature(short signatureAlgorithm)
	{
		return 0;
	}

	public static TlsSecret HkdfExpandLabel(TlsSecret secret, int cryptoHashAlgorithm, string label, byte[] context, int length)
	{
		return null;
	}
}
