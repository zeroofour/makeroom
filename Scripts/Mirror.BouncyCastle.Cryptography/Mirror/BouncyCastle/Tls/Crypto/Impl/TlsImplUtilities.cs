namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public abstract class TlsImplUtilities
{
	public static bool IsSsl(TlsCryptoParameters cryptoParams)
	{
		return false;
	}

	public static bool IsTlsV10(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV10(TlsCryptoParameters cryptoParams)
	{
		return false;
	}

	public static bool IsTlsV11(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV11(TlsCryptoParameters cryptoParams)
	{
		return false;
	}

	public static bool IsTlsV12(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV12(TlsCryptoParameters cryptoParams)
	{
		return false;
	}

	public static bool IsTlsV13(ProtocolVersion version)
	{
		return false;
	}

	public static bool IsTlsV13(TlsCryptoParameters cryptoParams)
	{
		return false;
	}

	public static byte[] CalculateKeyBlock(TlsCryptoParameters cryptoParams, int length)
	{
		return null;
	}
}
