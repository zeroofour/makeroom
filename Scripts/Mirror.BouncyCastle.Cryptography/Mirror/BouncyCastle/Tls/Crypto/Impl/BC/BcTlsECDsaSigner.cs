using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsaSigner : BcTlsDssSigner
{
	protected override short SignatureAlgorithm => 0;

	public BcTlsECDsaSigner(BcTlsCrypto crypto, ECPrivateKeyParameters privateKey)
		: base(null, null)
	{
	}

	protected override IDsa CreateDsaImpl(int cryptoHashAlgorithm)
	{
		return null;
	}
}
