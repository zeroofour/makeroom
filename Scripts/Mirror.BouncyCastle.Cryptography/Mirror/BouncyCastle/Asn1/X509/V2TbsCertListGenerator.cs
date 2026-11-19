using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class V2TbsCertListGenerator
{
	private DerInteger version;

	private AlgorithmIdentifier signature;

	private X509Name issuer;

	private Time thisUpdate;

	private Time nextUpdate;

	private X509Extensions extensions;

	private List<Asn1Sequence> crlEntries;

	public void SetSignature(AlgorithmIdentifier signature)
	{
	}

	public void SetIssuer(X509Name issuer)
	{
	}

	public void SetThisUpdate(Asn1UtcTime thisUpdate)
	{
	}

	public void SetNextUpdate(Asn1UtcTime nextUpdate)
	{
	}

	public void SetThisUpdate(Time thisUpdate)
	{
	}

	public void SetNextUpdate(Time nextUpdate)
	{
	}

	public void AddCrlEntry(Asn1Sequence crlEntry)
	{
	}

	public void AddCrlEntry(DerInteger userCertificate, Asn1UtcTime revocationDate, int reason)
	{
	}

	public void AddCrlEntry(DerInteger userCertificate, Time revocationDate, int reason)
	{
	}

	public void AddCrlEntry(DerInteger userCertificate, Time revocationDate, int reason, Asn1GeneralizedTime invalidityDate)
	{
	}

	public void AddCrlEntry(DerInteger userCertificate, Time revocationDate, X509Extensions extensions)
	{
	}

	public void SetExtensions(X509Extensions extensions)
	{
	}

	public Asn1Sequence GeneratePreTbsCertList()
	{
		return null;
	}

	public TbsCertificateList GenerateTbsCertList()
	{
		return null;
	}

	private Asn1Sequence GenerateTbsCertificateStructure()
	{
		return null;
	}
}
