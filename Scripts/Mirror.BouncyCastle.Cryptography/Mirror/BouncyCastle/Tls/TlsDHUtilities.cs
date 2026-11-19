using System.IO;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsDHUtilities
{
	public static TlsDHConfig CreateNamedDHConfig(TlsContext context, int namedGroup)
	{
		return null;
	}

	public static DHGroup GetDHGroup(TlsDHConfig dhConfig)
	{
		return null;
	}

	public static DHGroup GetNamedDHGroup(int namedGroup)
	{
		return null;
	}

	public static int GetMinimumFiniteFieldBits(int cipherSuite)
	{
		return 0;
	}

	public static bool IsDHCipherSuite(int cipherSuite)
	{
		return false;
	}

	public static int GetNamedGroupForDHParameters(BigInteger p, BigInteger g)
	{
		return 0;
	}

	public static DHGroup GetStandardGroupForDHParameters(BigInteger p, BigInteger g)
	{
		return null;
	}

	public static TlsDHConfig ReceiveDHConfig(TlsContext context, TlsDHGroupVerifier dhGroupVerifier, Stream input)
	{
		return null;
	}

	public static BigInteger ReadDHParameter(Stream input)
	{
		return null;
	}

	public static void WriteDHConfig(TlsDHConfig dhConfig, Stream output)
	{
	}

	public static void WriteDHParameter(BigInteger x, Stream output)
	{
	}
}
