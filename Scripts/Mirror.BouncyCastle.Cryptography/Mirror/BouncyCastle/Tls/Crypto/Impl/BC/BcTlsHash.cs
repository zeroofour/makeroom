using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsHash : TlsHash
{
	private readonly BcTlsCrypto m_crypto;

	private readonly int m_cryptoHashAlgorithm;

	private readonly IDigest m_digest;

	internal BcTlsHash(BcTlsCrypto crypto, int cryptoHashAlgorithm)
	{
	}

	private BcTlsHash(BcTlsCrypto crypto, int cryptoHashAlgorithm, IDigest digest)
	{
	}

	public void Update(byte[] data, int offSet, int length)
	{
	}

	public byte[] CalculateHash()
	{
		return null;
	}

	public TlsHash CloneHash()
	{
		return null;
	}

	public void Reset()
	{
	}
}
