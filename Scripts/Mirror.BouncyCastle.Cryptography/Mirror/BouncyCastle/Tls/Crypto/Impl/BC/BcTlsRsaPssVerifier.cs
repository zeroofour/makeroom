using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaPssVerifier : BcTlsVerifier
{
	private readonly int m_signatureScheme;

	public BcTlsRsaPssVerifier(BcTlsCrypto crypto, RsaKeyParameters publicKey, int signatureScheme)
		: base(null, null)
	{
	}

	public override bool VerifyRawSignature(DigitallySigned digitallySigned, byte[] hash)
	{
		return false;
	}
}
