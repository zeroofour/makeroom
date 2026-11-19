using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Operators.Utilities;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsSignedData
{
	private readonly CmsProcessable signedContent;

	private SignedData signedData;

	private ContentInfo contentInfo;

	private SignerInformationStore signerInfoStore;

	private IDictionary<string, byte[]> m_hashes;

	public int Version => 0;

	public DerObjectIdentifier SignedContentType => null;

	public CmsProcessable SignedContent => null;

	public ContentInfo ContentInfo => null;

	private CmsSignedData(CmsSignedData c)
	{
	}

	public CmsSignedData(byte[] sigBlock)
	{
	}

	public CmsSignedData(CmsProcessable signedContent, byte[] sigBlock)
	{
	}

	public CmsSignedData(IDictionary<string, byte[]> hashes, byte[] sigBlock)
	{
	}

	public CmsSignedData(CmsProcessable signedContent, Stream sigData)
	{
	}

	public CmsSignedData(Stream sigData)
	{
	}

	public CmsSignedData(CmsProcessable signedContent, ContentInfo sigData)
	{
	}

	public CmsSignedData(IDictionary<string, byte[]> hashes, ContentInfo sigData)
	{
	}

	public CmsSignedData(ContentInfo sigData)
	{
	}

	public SignerInformationStore GetSignerInfos()
	{
		return null;
	}

	public IStore<X509V2AttributeCertificate> GetAttributeCertificates()
	{
		return null;
	}

	public IStore<X509Certificate> GetCertificates()
	{
		return null;
	}

	public IStore<X509Crl> GetCrls()
	{
		return null;
	}

	public IStore<Asn1Encodable> GetOtherRevInfos(DerObjectIdentifier otherRevInfoFormat)
	{
		return null;
	}

	public ISet<AlgorithmIdentifier> GetDigestAlgorithmIDs()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetEncoded(string encoding)
	{
		return null;
	}

	public static CmsSignedData AddDigestAlgorithm(CmsSignedData signedData, AlgorithmIdentifier digestAlgorithm)
	{
		return null;
	}

	public static CmsSignedData AddDigestAlgorithm(CmsSignedData signedData, AlgorithmIdentifier digestAlgorithm, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
		return null;
	}

	public static CmsSignedData ReplaceSigners(CmsSignedData signedData, SignerInformationStore signerInformationStore)
	{
		return null;
	}

	public static CmsSignedData ReplaceSigners(CmsSignedData signedData, SignerInformationStore signerInformationStore, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
		return null;
	}

	public static CmsSignedData ReplaceCertificatesAndCrls(CmsSignedData signedData, IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls)
	{
		return null;
	}

	public static CmsSignedData ReplaceCertificatesAndCrls(CmsSignedData signedData, IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls, IStore<X509V2AttributeCertificate> x509AttrCerts)
	{
		return null;
	}

	public static CmsSignedData ReplaceCertificatesAndRevocations(CmsSignedData signedData, IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls, IStore<X509V2AttributeCertificate> x509AttrCerts, IStore<OtherRevocationInfoFormat> otherRevocationInfos)
	{
		return null;
	}
}
