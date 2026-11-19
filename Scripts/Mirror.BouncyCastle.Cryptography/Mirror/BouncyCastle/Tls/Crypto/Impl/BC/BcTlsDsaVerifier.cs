using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDsaVerifier : BcTlsDssVerifier
{
	protected override short SignatureAlgorithm => 0;

	public BcTlsDsaVerifier(BcTlsCrypto crypto, DsaPublicKeyParameters publicKey)
		: base(null, null)
	{
	}

	protected override IDsa CreateDsaImpl()
	{
		return null;
	}
}
