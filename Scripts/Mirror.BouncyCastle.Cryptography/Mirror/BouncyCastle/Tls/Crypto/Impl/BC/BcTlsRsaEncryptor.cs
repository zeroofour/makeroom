using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsRsaEncryptor : TlsEncryptor
{
	private readonly BcTlsCrypto m_crypto;

	private readonly RsaKeyParameters m_pubKeyRsa;

	private static RsaKeyParameters CheckPublicKey(RsaKeyParameters pubKeyRsa)
	{
		return null;
	}

	internal BcTlsRsaEncryptor(BcTlsCrypto crypto, RsaKeyParameters pubKeyRsa)
	{
	}

	public byte[] Encrypt(byte[] input, int inOff, int length)
	{
		return null;
	}
}
