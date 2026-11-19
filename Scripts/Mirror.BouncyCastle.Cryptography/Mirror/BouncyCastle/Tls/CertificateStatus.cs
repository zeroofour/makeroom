using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1.Ocsp;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateStatus
{
	private readonly short m_statusType;

	private readonly object m_response;

	public short StatusType => 0;

	public object Response => null;

	public OcspResponse OcspResponse => null;

	public IList<OcspResponse> OcspResponseList => null;

	public CertificateStatus(short statusType, object response)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static CertificateStatus Parse(TlsContext context, Stream input)
	{
		return null;
	}

	private static bool IsCorrectType(short statusType, object response)
	{
		return false;
	}

	private static bool IsOcspResponseList(object response)
	{
		return false;
	}

	private static OcspResponse ParseOcspResponse(byte[] derEncoding)
	{
		return null;
	}

	private static void RequireStatusRequestVersion(int minVersion, int statusRequestVersion)
	{
	}
}
