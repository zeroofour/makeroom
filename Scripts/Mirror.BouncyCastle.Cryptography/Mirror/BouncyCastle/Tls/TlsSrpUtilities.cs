using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsSrpUtilities
{
	public static void AddSrpExtension(IDictionary<int, byte[]> extensions, byte[] identity)
	{
	}

	public static byte[] GetSrpExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static byte[] CreateSrpExtension(byte[] identity)
	{
		return null;
	}

	public static byte[] ReadSrpExtension(byte[] extensionData)
	{
		return null;
	}

	public static BigInteger ReadSrpParameter(Stream input)
	{
		return null;
	}

	public static void WriteSrpParameter(BigInteger x, Stream output)
	{
	}

	public static bool IsSrpCipherSuite(int cipherSuite)
	{
		return false;
	}
}
