using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal class BcTlsAeadCipherImpl : TlsAeadCipherImpl
{
	private readonly bool m_isEncrypting;

	internal readonly IAeadCipher m_cipher;

	private KeyParameter key;

	internal BcTlsAeadCipherImpl(IAeadCipher cipher, bool isEncrypting)
	{
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
	}

	public void Init(byte[] nonce, int macSize, byte[] additionalData)
	{
	}

	public int GetOutputSize(int inputLength)
	{
		return 0;
	}

	public virtual int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}

	public virtual int DoFinal(byte[] additionalData, byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}

	public void Reset()
	{
	}
}
