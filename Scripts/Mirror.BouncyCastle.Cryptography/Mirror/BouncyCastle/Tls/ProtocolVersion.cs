namespace Mirror.BouncyCastle.Tls;

public sealed class ProtocolVersion
{
	public static readonly ProtocolVersion SSLv3;

	public static readonly ProtocolVersion TLSv10;

	public static readonly ProtocolVersion TLSv11;

	public static readonly ProtocolVersion TLSv12;

	public static readonly ProtocolVersion TLSv13;

	public static readonly ProtocolVersion DTLSv10;

	public static readonly ProtocolVersion DTLSv12;

	public static readonly ProtocolVersion DTLSv13;

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_DTLS;

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_TLS;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_DTLS;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_TLS;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_DTLS;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_TLS;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_DTLS;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_TLS;

	private readonly int version;

	private readonly string name;

	public int FullVersion => 0;

	public int MajorVersion => 0;

	public int MinorVersion => 0;

	public string Name => null;

	public bool IsDtls => false;

	public bool IsSsl => false;

	public bool IsTls => false;

	public static bool Contains(ProtocolVersion[] versions, ProtocolVersion version)
	{
		return false;
	}

	public static ProtocolVersion GetEarliestDtls(ProtocolVersion[] versions)
	{
		return null;
	}

	public static ProtocolVersion GetEarliestTls(ProtocolVersion[] versions)
	{
		return null;
	}

	public static ProtocolVersion GetLatestDtls(ProtocolVersion[] versions)
	{
		return null;
	}

	public static ProtocolVersion GetLatestTls(ProtocolVersion[] versions)
	{
		return null;
	}

	internal static bool IsSupportedDtlsVersionClient(ProtocolVersion version)
	{
		return false;
	}

	internal static bool IsSupportedDtlsVersionServer(ProtocolVersion version)
	{
		return false;
	}

	internal static bool IsSupportedTlsVersionClient(ProtocolVersion version)
	{
		return false;
	}

	internal static bool IsSupportedTlsVersionServer(ProtocolVersion version)
	{
		return false;
	}

	private ProtocolVersion(int v, string name)
	{
	}

	public ProtocolVersion[] DownTo(ProtocolVersion min)
	{
		return null;
	}

	public ProtocolVersion GetEquivalentTlsVersion()
	{
		return null;
	}

	public ProtocolVersion GetNextVersion()
	{
		return null;
	}

	public ProtocolVersion GetPreviousVersion()
	{
		return null;
	}

	public bool IsEarlierVersionOf(ProtocolVersion version)
	{
		return false;
	}

	public bool IsEqualOrEarlierVersionOf(ProtocolVersion version)
	{
		return false;
	}

	public bool IsEqualOrLaterVersionOf(ProtocolVersion version)
	{
		return false;
	}

	public bool IsLaterVersionOf(ProtocolVersion version)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(ProtocolVersion other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static ProtocolVersion Get(int major, int minor)
	{
		return null;
	}

	public ProtocolVersion[] Only()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static void CheckUint8(int versionOctet)
	{
	}

	private static ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
	{
		return null;
	}
}
