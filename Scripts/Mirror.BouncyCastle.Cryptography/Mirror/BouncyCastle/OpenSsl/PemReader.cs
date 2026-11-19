using System.IO;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Pkcs;
using Mirror.BouncyCastle.Utilities.IO.Pem;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.OpenSsl;

public class PemReader : Mirror.BouncyCastle.Utilities.IO.Pem.PemReader
{
	private readonly IPasswordFinder pFinder;

	static PemReader()
	{
	}

	public PemReader(TextReader reader)
		: base(null)
	{
	}

	public PemReader(TextReader reader, IPasswordFinder pFinder)
		: base(null)
	{
	}

	public object ReadObject()
	{
		return null;
	}

	private AsymmetricKeyParameter ReadRsaPublicKey(PemObject pemObject)
	{
		return null;
	}

	private AsymmetricKeyParameter ReadPublicKey(PemObject pemObject)
	{
		return null;
	}

	private X509Certificate ReadCertificate(PemObject pemObject)
	{
		return null;
	}

	private X509Crl ReadCrl(PemObject pemObject)
	{
		return null;
	}

	private Pkcs10CertificationRequest ReadCertificateRequest(PemObject pemObject)
	{
		return null;
	}

	private X509V2AttributeCertificate ReadAttributeCertificate(PemObject pemObject)
	{
		return null;
	}

	private ContentInfo ReadPkcs7(PemObject pemObject)
	{
		return null;
	}

	private object ReadPrivateKey(PemObject pemObject)
	{
		return null;
	}
}
