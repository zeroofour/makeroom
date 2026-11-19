using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pkcs;

public class Pkcs12StoreBuilder
{
	private DerObjectIdentifier keyAlgorithm;

	private DerObjectIdentifier certAlgorithm;

	private DerObjectIdentifier keyPrfAlgorithm;

	private bool useDerEncoding;

	private bool reverseCertificates;

	public Pkcs12Store Build()
	{
		return null;
	}

	public Pkcs12StoreBuilder SetReverseCertificates(bool reverseCertificates)
	{
		return null;
	}

	public Pkcs12StoreBuilder SetCertAlgorithm(DerObjectIdentifier certAlgorithm)
	{
		return null;
	}

	public Pkcs12StoreBuilder SetKeyAlgorithm(DerObjectIdentifier keyAlgorithm)
	{
		return null;
	}

	public Pkcs12StoreBuilder SetKeyAlgorithm(DerObjectIdentifier keyAlgorithm, DerObjectIdentifier keyPrfAlgorithm)
	{
		return null;
	}

	public Pkcs12StoreBuilder SetUseDerEncoding(bool useDerEncoding)
	{
		return null;
	}
}
