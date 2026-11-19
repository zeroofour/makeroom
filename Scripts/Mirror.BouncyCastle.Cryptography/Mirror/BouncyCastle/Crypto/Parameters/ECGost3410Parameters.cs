using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ECGost3410Parameters : ECNamedDomainParameters
{
	private readonly DerObjectIdentifier _publicKeyParamSet;

	private readonly DerObjectIdentifier _digestParamSet;

	private readonly DerObjectIdentifier _encryptionParamSet;

	public DerObjectIdentifier PublicKeyParamSet => null;

	public DerObjectIdentifier DigestParamSet => null;

	public DerObjectIdentifier EncryptionParamSet => null;

	public ECGost3410Parameters(ECNamedDomainParameters dp, DerObjectIdentifier publicKeyParamSet, DerObjectIdentifier digestParamSet, DerObjectIdentifier encryptionParamSet)
		: base((DerObjectIdentifier)null, (ECDomainParameters)null)
	{
	}

	public ECGost3410Parameters(ECDomainParameters dp, DerObjectIdentifier publicKeyParamSet, DerObjectIdentifier digestParamSet, DerObjectIdentifier encryptionParamSet)
		: base((DerObjectIdentifier)null, (ECDomainParameters)null)
	{
	}
}
