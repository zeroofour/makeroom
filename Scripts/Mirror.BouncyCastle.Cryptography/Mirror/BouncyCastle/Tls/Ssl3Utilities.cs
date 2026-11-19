using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal abstract class Ssl3Utilities
{
	private static readonly byte[] SSL_CLIENT;

	private static readonly byte[] SSL_SERVER;

	private const byte IPAD_BYTE = 54;

	private const byte OPAD_BYTE = 92;

	private static readonly byte[] IPAD;

	private static readonly byte[] OPAD;

	internal static byte[] CalculateVerifyData(TlsHandshakeHash handshakeHash, bool isServer)
	{
		return null;
	}

	internal static void CompleteCombinedHash(TlsContext context, TlsHash md5, TlsHash sha1)
	{
	}

	private static void CompleteHash(byte[] master_secret, TlsHash hash, int padLength)
	{
	}

	private static byte[] GenPad(byte b, int count)
	{
		return null;
	}

	internal static byte[] ReadEncryptedPms(Stream input)
	{
		return null;
	}

	internal static void WriteEncryptedPms(byte[] encryptedPms, Stream output)
	{
	}
}
