using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaSigner : BcTlsSigner
{
	private readonly RsaKeyParameters m_publicKey;

	public BcTlsRsaSigner(BcTlsCrypto crypto, RsaKeyParameters privateKey, RsaKeyParameters publicKey)
		: base(null, null)
	{
	}

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		return null;
	}
}
