namespace Mirror.BouncyCastle.Tls;

public abstract class CertificateCompressionAlgorithm
{
	public const int zlib = 1;

	public const int brotli = 2;

	public const int zstd = 3;

	public static string GetName(int certificateCompressionAlgorithm)
	{
		return null;
	}

	public static string GetText(int certificateCompressionAlgorithm)
	{
		return null;
	}

	public static bool IsRecognized(int certificateCompressionAlgorithm)
	{
		return false;
	}
}
