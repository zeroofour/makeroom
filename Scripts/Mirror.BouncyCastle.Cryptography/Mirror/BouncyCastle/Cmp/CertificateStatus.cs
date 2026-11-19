using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Operators.Utilities;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cmp;

public class CertificateStatus
{
	private readonly IDigestAlgorithmFinder m_digestAlgorithmFinder;

	private readonly CertStatus m_certStatus;

	public virtual PkiStatusInfo StatusInfo => null;

	public virtual DerInteger CertReqID => null;

	[Obsolete("Use 'CertReqID' instead")]
	public virtual BigInteger CertRequestID => null;

	[Obsolete("Use constructor taking 'IDigestAlgorithmFinder' instead")]
	public CertificateStatus(DefaultDigestAlgorithmIdentifierFinder digestAlgFinder, CertStatus certStatus)
	{
	}

	public CertificateStatus(IDigestAlgorithmFinder digestAlgorithmFinder, CertStatus certStatus)
	{
	}

	public virtual bool IsVerified(X509Certificate cert)
	{
		return false;
	}

	public virtual bool IsVerified(CmpCertificate cmpCertificate, AlgorithmIdentifier signatureAlgorithm)
	{
		return false;
	}
}
