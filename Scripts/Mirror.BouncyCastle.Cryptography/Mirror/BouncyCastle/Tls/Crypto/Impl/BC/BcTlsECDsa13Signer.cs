using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsa13Signer : BcTlsSigner
{
	private readonly int m_signatureScheme;

	public BcTlsECDsa13Signer(BcTlsCrypto crypto, ECPrivateKeyParameters privateKey, int signatureScheme)
		: base(null, null)
	{
	}

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		return null;
	}
}
