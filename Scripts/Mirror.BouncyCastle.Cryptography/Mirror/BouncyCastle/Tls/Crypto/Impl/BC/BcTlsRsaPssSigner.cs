using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaPssSigner : BcTlsSigner
{
	private readonly int m_signatureScheme;

	public BcTlsRsaPssSigner(BcTlsCrypto crypto, RsaKeyParameters privateKey, int signatureScheme)
		: base(null, null)
	{
	}

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		return null;
	}
}
