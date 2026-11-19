using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateStatusRequest
{
	private short m_statusType;

	private object m_request;

	public short StatusType => 0;

	public object Request => null;

	public OcspStatusRequest OcspStatusRequest => null;

	public CertificateStatusRequest(short statusType, object request)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static CertificateStatusRequest Parse(Stream input)
	{
		return null;
	}

	private static bool IsCorrectType(short statusType, object request)
	{
		return false;
	}
}
