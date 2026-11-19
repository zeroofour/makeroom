using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsBlockCipherImpl : TlsBlockCipherImpl
{
	private readonly bool m_isEncrypting;

	private readonly IBlockCipher m_cipher;

	private KeyParameter key;

	internal BcTlsBlockCipherImpl(IBlockCipher cipher, bool isEncrypting)
	{
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
	}

	public void Init(byte[] iv, int ivOff, int ivLen)
	{
	}

	public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}

	public int GetBlockSize()
	{
		return 0;
	}
}
