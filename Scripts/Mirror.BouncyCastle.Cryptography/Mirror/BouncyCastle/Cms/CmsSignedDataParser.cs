using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsSignedDataParser : CmsContentInfoParser
{
	private SignedDataParser _signedData;

	private DerObjectIdentifier _signedContentType;

	private CmsTypedStream _signedContent;

	private Dictionary<string, IDigest> m_digests;

	private HashSet<string> m_digestOids;

	private SignerInformationStore _signerInfoStore;

	private Asn1Set _certSet;

	private Asn1Set _crlSet;

	private bool _isCertCrlParsed;

	public int Version => 0;

	public ISet<string> DigestOids => null;

	public DerObjectIdentifier SignedContentType => null;

	public CmsSignedDataParser(byte[] sigBlock)
		: base(null)
	{
	}

	public CmsSignedDataParser(CmsTypedStream signedContent, byte[] sigBlock)
		: base(null)
	{
	}

	public CmsSignedDataParser(Stream sigData)
		: base(null)
	{
	}

	public CmsSignedDataParser(CmsTypedStream signedContent, Stream sigData)
		: base(null)
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

	private void PopulateCertCrlSets()
	{
	}

	public CmsTypedStream GetSignedContent()
	{
		return null;
	}

	public static Stream ReplaceSigners(Stream original, SignerInformationStore signerInformationStore, Stream outStr)
	{
		return null;
	}

	public static Stream ReplaceCertificatesAndCrls(Stream original, IStore<X509Certificate> x509Certs, IStore<X509Crl> x509Crls, IStore<X509V2AttributeCertificate> x509AttrCerts, Stream outStr)
	{
		return null;
	}

	private static Asn1Set GetAsn1Set(Asn1SetParser asn1SetParser)
	{
		return null;
	}
}
