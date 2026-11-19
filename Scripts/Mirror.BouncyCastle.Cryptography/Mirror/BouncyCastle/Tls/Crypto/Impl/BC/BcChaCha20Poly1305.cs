using Mirror.BouncyCastle.Crypto.Engines;
using Mirror.BouncyCastle.Crypto.Macs;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public sealed class BcChaCha20Poly1305 : TlsAeadCipherImpl
{
	private static readonly byte[] Zeroes;

	private readonly ChaCha7539Engine m_cipher;

	private readonly Poly1305 m_mac;

	private readonly bool m_isEncrypting;

	private int m_additionalDataLength;

	public BcChaCha20Poly1305(bool isEncrypting)
	{
	}

	public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}

	public int DoFinal(byte[] additionalData, byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}

	public int GetOutputSize(int inputLength)
	{
		return 0;
	}

	public void Init(byte[] nonce, int macSize, byte[] additionalData)
	{
	}

	public void Reset()
	{
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
	}

	private void InitMac()
	{
	}

	private void UpdateMac(byte[] buf, int off, int len)
	{
	}
}
