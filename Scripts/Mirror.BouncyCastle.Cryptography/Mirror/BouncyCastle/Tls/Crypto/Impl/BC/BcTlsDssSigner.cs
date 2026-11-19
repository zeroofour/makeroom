using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsDssSigner : BcTlsSigner
{
	protected abstract short SignatureAlgorithm { get; }

	protected BcTlsDssSigner(BcTlsCrypto crypto, AsymmetricKeyParameter privateKey)
		: base(null, null)
	{
	}

	protected abstract IDsa CreateDsaImpl(int cryptoHashAlgorithm);

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		return null;
	}
}
