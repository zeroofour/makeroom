using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Operators.Utilities;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cmp;

public sealed class CertificateConfirmationContentBuilder
{
	private readonly IDigestAlgorithmFinder m_digestAlgorithmFinder;

	private readonly List<CmpCertificate> m_acceptedCerts;

	private readonly List<AlgorithmIdentifier> m_acceptedSignatureAlgorithms;

	private readonly List<DerInteger> m_acceptedReqIDs;

	public CertificateConfirmationContentBuilder()
	{
	}

	[Obsolete("Use constructor taking 'IDigestAlgorithmFinder' instead")]
	public CertificateConfirmationContentBuilder(DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
	{
	}

	public CertificateConfirmationContentBuilder(IDigestAlgorithmFinder digestAlgorithmFinder)
	{
	}

	public CertificateConfirmationContentBuilder AddAcceptedCertificate(X509Certificate certHolder, BigInteger certReqId)
	{
		return null;
	}

	public CertificateConfirmationContentBuilder AddAcceptedCertificate(X509Certificate cert, DerInteger certReqID)
	{
		return null;
	}

	public CertificateConfirmationContentBuilder AddAcceptedCertificate(CmpCertificate cmpCertificate, AlgorithmIdentifier signatureAlgorithm, DerInteger certReqID)
	{
		return null;
	}

	public CertificateConfirmationContent Build()
	{
		return null;
	}
}
