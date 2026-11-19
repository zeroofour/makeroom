using System.Collections.Generic;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsSrtpUtilities
{
	public static void AddUseSrtpExtension(IDictionary<int, byte[]> extensions, UseSrtpData useSrtpData)
	{
	}

	public static UseSrtpData GetUseSrtpExtension(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	public static byte[] CreateUseSrtpExtension(UseSrtpData useSrtpData)
	{
		return null;
	}

	public static UseSrtpData ReadUseSrtpExtension(byte[] extensionData)
	{
		return null;
	}
}
