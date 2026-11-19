using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pkcs;

public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
{
	protected Pkcs10CertificationRequestDelaySigned()
	{
	}

	public Pkcs10CertificationRequestDelaySigned(byte[] encoded)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(Asn1Sequence seq)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(Stream input)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes, AsymmetricKeyParameter signingKey)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes)
	{
	}

	public byte[] GetDataToSign()
	{
		return null;
	}

	public void SignRequest(byte[] signedData)
	{
	}

	public void SignRequest(DerBitString signedData)
	{
	}
}
