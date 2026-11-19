using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateStatusRequestItemV2
{
	private readonly short m_statusType;

	private readonly object m_request;

	public short StatusType => 0;

	public object Request => null;

	public OcspStatusRequest OcspStatusRequest => null;

	public CertificateStatusRequestItemV2(short statusType, object request)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static CertificateStatusRequestItemV2 Parse(Stream input)
	{
		return null;
	}

	private static bool IsCorrectType(short statusType, object request)
	{
		return false;
	}
}
