using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.X509;

public class X509AttrCertParser
{
	private static readonly PemParser PemAttrCertParser;

	private Asn1Set sData;

	private int sDataObjectCount;

	private Stream currentStream;

	private X509V2AttributeCertificate ReadDerCertificate(Asn1InputStream dIn)
	{
		return null;
	}

	private X509V2AttributeCertificate GetCertificate()
	{
		return null;
	}

	private X509V2AttributeCertificate ReadPemCertificate(Stream inStream)
	{
		return null;
	}

	public X509V2AttributeCertificate ReadAttrCert(byte[] input)
	{
		return null;
	}

	public IList<X509V2AttributeCertificate> ReadAttrCerts(byte[] input)
	{
		return null;
	}

	public X509V2AttributeCertificate ReadAttrCert(Stream inStream)
	{
		return null;
	}

	public IList<X509V2AttributeCertificate> ReadAttrCerts(Stream inStream)
	{
		return null;
	}
}
