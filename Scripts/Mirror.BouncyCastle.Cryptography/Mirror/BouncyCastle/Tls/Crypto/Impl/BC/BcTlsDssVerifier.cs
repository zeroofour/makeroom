using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsDssVerifier : BcTlsVerifier
{
	protected abstract short SignatureAlgorithm { get; }

	protected BcTlsDssVerifier(BcTlsCrypto crypto, AsymmetricKeyParameter publicKey)
		: base(null, null)
	{
	}

	protected abstract IDsa CreateDsaImpl();

	public override bool VerifyRawSignature(DigitallySigned digitallySigned, byte[] hash)
	{
		return false;
	}
}
