namespace Mirror.BouncyCastle.Asn1.X509;

public class V2AttributeCertificateInfoGenerator
{
	internal DerInteger version;

	internal Holder holder;

	internal AttCertIssuer issuer;

	internal AlgorithmIdentifier signature;

	internal DerInteger serialNumber;

	internal Asn1EncodableVector attributes;

	internal DerBitString issuerUniqueID;

	internal X509Extensions extensions;

	internal Asn1GeneralizedTime startDate;

	internal Asn1GeneralizedTime endDate;

	public void SetHolder(Holder holder)
	{
	}

	public void AddAttribute(string oid, Asn1Encodable value)
	{
	}

	public void AddAttribute(AttributeX509 attribute)
	{
	}

	public void SetSerialNumber(DerInteger serialNumber)
	{
	}

	public void SetSignature(AlgorithmIdentifier signature)
	{
	}

	public void SetIssuer(AttCertIssuer issuer)
	{
	}

	public void SetStartDate(Asn1GeneralizedTime startDate)
	{
	}

	public void SetEndDate(Asn1GeneralizedTime endDate)
	{
	}

	public void SetIssuerUniqueID(DerBitString issuerUniqueID)
	{
	}

	public void SetExtensions(X509Extensions extensions)
	{
	}

	public AttributeCertificateInfo GenerateAttributeCertificateInfo()
	{
		return null;
	}
}
