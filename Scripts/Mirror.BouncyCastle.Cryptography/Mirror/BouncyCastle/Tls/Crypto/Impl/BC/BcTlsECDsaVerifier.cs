using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsaVerifier : BcTlsDssVerifier
{
	protected override short SignatureAlgorithm => 0;

	public BcTlsECDsaVerifier(BcTlsCrypto crypto, ECPublicKeyParameters publicKey)
		: base(null, null)
	{
	}

	protected override IDsa CreateDsaImpl()
	{
		return null;
	}
}
