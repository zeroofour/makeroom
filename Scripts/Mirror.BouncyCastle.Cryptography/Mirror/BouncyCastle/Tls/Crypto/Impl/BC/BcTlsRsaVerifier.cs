using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaVerifier : BcTlsVerifier
{
	public BcTlsRsaVerifier(BcTlsCrypto crypto, RsaKeyParameters publicKey)
		: base(null, null)
	{
	}

	public override bool VerifyRawSignature(DigitallySigned digitallySigned, byte[] hash)
	{
		return false;
	}
}
