namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public class TlsBlockCipher : TlsCipher, TlsCipherExt
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly byte[] m_randomData;

	protected readonly bool m_encryptThenMac;

	protected readonly bool m_useExplicitIV;

	protected readonly bool m_acceptExtraPadding;

	protected readonly bool m_useExtraPadding;

	protected readonly TlsBlockCipherImpl m_decryptCipher;

	protected readonly TlsBlockCipherImpl m_encryptCipher;

	protected readonly TlsSuiteHmac m_readMac;

	protected readonly TlsSuiteHmac m_writeMac;

	protected readonly byte[] m_decryptConnectionID;

	protected readonly byte[] m_encryptConnectionID;

	protected readonly bool m_decryptUseInnerPlaintext;

	protected readonly bool m_encryptUseInnerPlaintext;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsBlockCipher(TlsCryptoParameters cryptoParams, TlsBlockCipherImpl encryptCipher, TlsBlockCipherImpl decryptCipher, TlsHmac clientMac, TlsHmac serverMac, int cipherKeySize)
	{
	}

	public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return 0;
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		return 0;
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return 0;
	}

	public virtual int GetPlaintextDecodeLimit(int ciphertextLimit)
	{
		return 0;
	}

	public virtual int GetPlaintextEncodeLimit(int ciphertextLimit)
	{
		return 0;
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		return null;
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		return null;
	}

	public virtual void RekeyDecoder()
	{
	}

	public virtual void RekeyEncoder()
	{
	}

	protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
	{
		return 0;
	}

	protected virtual int ChooseExtraPadBlocks(int max)
	{
		return 0;
	}

	protected virtual int GetCiphertextLength(int blockSize, int macSize, int maxPadding, int plaintextLength)
	{
		return 0;
	}

	protected virtual int GetPlaintextLength(int blockSize, int macSize, int ciphertextLength)
	{
		return 0;
	}
}
