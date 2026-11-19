namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public class TlsNullCipher : TlsCipher, TlsCipherExt
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly TlsSuiteHmac m_readMac;

	protected readonly TlsSuiteHmac m_writeMac;

	protected readonly byte[] m_decryptConnectionID;

	protected readonly byte[] m_encryptConnectionID;

	protected readonly bool m_decryptUseInnerPlaintext;

	protected readonly bool m_encryptUseInnerPlaintext;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsNullCipher(TlsCryptoParameters cryptoParams, TlsHmac clientMac, TlsHmac serverMac)
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
}
