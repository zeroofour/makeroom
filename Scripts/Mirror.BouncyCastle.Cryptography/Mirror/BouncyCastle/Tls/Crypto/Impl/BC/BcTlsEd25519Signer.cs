using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsEd25519Signer : BcTlsSigner
{
	public BcTlsEd25519Signer(BcTlsCrypto crypto, Ed25519PrivateKeyParameters privateKey)
		: base(null, null)
	{
	}

	public override TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		return null;
	}
}
