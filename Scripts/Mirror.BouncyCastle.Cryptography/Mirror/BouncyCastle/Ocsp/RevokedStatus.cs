using System;
using Mirror.BouncyCastle.Asn1.Ocsp;

namespace Mirror.BouncyCastle.Ocsp;

public class RevokedStatus : CertificateStatus
{
	private readonly RevokedInfo m_revokedInfo;

	public DateTime RevocationTime => default;

	public bool HasRevocationReason => false;

	public int RevocationReason => 0;

	public RevokedStatus(RevokedInfo revokedInfo)
	{
	}

	public RevokedStatus(DateTime revocationDate)
	{
	}

	public RevokedStatus(DateTime revocationDate, int reason)
	{
	}
}
