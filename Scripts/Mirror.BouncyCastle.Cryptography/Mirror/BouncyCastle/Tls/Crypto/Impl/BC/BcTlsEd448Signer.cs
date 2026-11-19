using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsEd448Signer : BcTlsSigner
{
	public BcTlsEd448Signer(BcTlsCrypto crypto, Ed448PrivateKeyParameters privateKey)
		: base(null, null)
	{
	}

	public override TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		return null;
	}
}
