using System;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Operators.Utilities;

namespace Mirror.BouncyCastle.Cmp;

public class CertificateConfirmationContent
{
	private readonly CertConfirmContent m_content;

	private readonly IDigestAlgorithmFinder m_digestAlgorithmFinder;

	public static CertificateConfirmationContent FromPkiBody(PkiBody pkiBody)
	{
		return null;
	}

	public static CertificateConfirmationContent FromPkiBody(PkiBody pkiBody, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
		return null;
	}

	public static bool IsCertificateConfirmationContent(int bodyType)
	{
		return false;
	}

	public CertificateConfirmationContent(CertConfirmContent content)
	{
	}

	[Obsolete("Use constructor taking 'IDigestAlgorithmFinder' instead")]
	public CertificateConfirmationContent(CertConfirmContent content, DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
	{
	}

	public CertificateConfirmationContent(CertConfirmContent content, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
	}

	public CertConfirmContent ToAsn1Structure()
	{
		return null;
	}

	public CertificateStatus[] GetStatusMessages()
	{
		return null;
	}
}
