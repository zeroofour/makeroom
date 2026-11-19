using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsEccUtilities
{
	public static TlsECConfig CreateNamedECConfig(TlsContext context, int namedGroup)
	{
		return null;
	}

	public static int GetMinimumCurveBits(int cipherSuite)
	{
		return 0;
	}

	public static bool IsEccCipherSuite(int cipherSuite)
	{
		return false;
	}

	public static void CheckPointEncoding(int namedGroup, byte[] encoding)
	{
	}

	public static TlsECConfig ReceiveECDHConfig(TlsContext context, Stream input)
	{
		return null;
	}

	public static void WriteECConfig(TlsECConfig ecConfig, Stream output)
	{
	}

	public static void WriteNamedECParameters(int namedGroup, Stream output)
	{
	}
}
