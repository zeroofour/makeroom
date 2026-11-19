namespace Mirror.BouncyCastle.Crypto;

public static class AesUtilities
{
	public static bool IsHardwareAccelerated => false;

	public static IBlockCipher CreateEngine()
	{
		return null;
	}
}
