using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public abstract class CmsSignedGenerator
{
	public static readonly string Data;

	public static readonly string DigestSha1;

	public static readonly string DigestSha224;

	public static readonly string DigestSha256;

	public static readonly string DigestSha384;

	public static readonly string DigestSha512;

	public static readonly string DigestSha512_224;

	public static readonly string DigestSha512_256;

	public static readonly string DigestMD5;

	public static readonly string DigestGost3411;

	public static readonly string DigestRipeMD128;

	public static readonly string DigestRipeMD160;

	public static readonly string DigestRipeMD256;

	public static readonly string EncryptionRsa;

	public static readonly string EncryptionDsa;

	public static readonly string EncryptionECDsa;

	public static readonly string EncryptionRsaPss;

	public static readonly string EncryptionGost3410;

	public static readonly string EncryptionECGost3410;

	public static readonly string EncryptionECGost3410_2012_256;

	public static readonly string EncryptionECGost3410_2012_512;

	internal List<Asn1Encodable> _certs;

	internal List<Asn1Encodable> _crls;

	internal IList<SignerInformation> _signers;

	internal IDictionary<DerObjectIdentifier, byte[]> m_digests;

	internal bool _useDerForCerts;

	internal bool _useDerForCrls;

	protected readonly SecureRandom m_random;

	public bool UseDerForCerts
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseDerForCrls
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected CmsSignedGenerator()
	{
	}

	protected CmsSignedGenerator(SecureRandom random)
	{
	}

	protected internal virtual IDictionary<CmsAttributeTableParameter, object> GetBaseParameters(DerObjectIdentifier contentType, AlgorithmIdentifier digAlgId, byte[] hash)
	{
		return null;
	}

	protected internal virtual Asn1Set GetAttributeSet(Mirror.BouncyCastle.Asn1.Cms.AttributeTable attr)
	{
		return null;
	}

	public void AddAttributeCertificate(X509V2AttributeCertificate attrCert)
	{
	}

	public void AddAttributeCertificates(IStore<X509V2AttributeCertificate> attrCertStore)
	{
	}

	public void AddCertificate(X509Certificate cert)
	{
	}

	public void AddCertificates(IStore<X509Certificate> certStore)
	{
	}

	public void AddCrl(X509Crl crl)
	{
	}

	public void AddCrls(IStore<X509Crl> crlStore)
	{
	}

	public void AddOtherRevocationInfo(OtherRevocationInfoFormat otherRevocationInfo)
	{
	}

	public void AddOtherRevocationInfos(IStore<OtherRevocationInfoFormat> otherRevocationInfoStore)
	{
	}

	public void AddOtherRevocationInfos(DerObjectIdentifier otherRevInfoFormat, IStore<Asn1Encodable> otherRevInfoStore)
	{
	}

	public void AddSigners(SignerInformationStore signerStore)
	{
	}

	public IDictionary<string, byte[]> GetGeneratedDigests()
	{
		return null;
	}

	internal virtual void AddSignerCallback(SignerInformation si)
	{
	}

	internal static SignerIdentifier GetSignerIdentifier(X509Certificate cert)
	{
		return null;
	}

	internal static SignerIdentifier GetSignerIdentifier(byte[] subjectKeyIdentifier)
	{
		return null;
	}
}
