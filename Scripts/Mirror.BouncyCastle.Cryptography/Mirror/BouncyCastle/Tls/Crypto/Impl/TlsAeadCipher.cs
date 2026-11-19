namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public class TlsAeadCipher : TlsCipher, TlsCipherExt
{
	public const int AEAD_CCM = 1;

	public const int AEAD_CHACHA20_POLY1305 = 2;

	public const int AEAD_GCM = 3;

	private const int NONCE_RFC5288 = 1;

	private const int NONCE_RFC7905 = 2;

	private const long SequenceNumberPlaceholder = -1L;

	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly int m_keySize;

	protected readonly int m_macSize;

	protected readonly int m_fixed_iv_length;

	protected readonly int m_record_iv_length;

	protected readonly TlsAeadCipherImpl m_decryptCipher;

	protected readonly TlsAeadCipherImpl m_encryptCipher;

	protected readonly byte[] m_decryptNonce;

	protected readonly byte[] m_encryptNonce;

	protected readonly byte[] m_decryptConnectionID;

	protected readonly byte[] m_encryptConnectionID;

	protected readonly bool m_decryptUseInnerPlaintext;

	protected readonly bool m_encryptUseInnerPlaintext;

	protected readonly bool m_isTlsV13;

	protected readonly int m_nonceMode;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsAeadCipher(TlsCryptoParameters cryptoParams, TlsAeadCipherImpl encryptCipher, TlsAeadCipherImpl decryptCipher, int keySize, int macSize, int aeadType)
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

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
		return null;
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int ciphertextOffset, int ciphertextLength)
	{
		return null;
	}

	public virtual void RekeyDecoder()
	{
	}

	public virtual void RekeyEncoder()
	{
	}

	protected virtual byte[] GetAdditionalData(long seqNo, short recordType, ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength)
	{
		return null;
	}

	protected virtual byte[] GetAdditionalData(long seqNo, short recordType, ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength, byte[] connectionID)
	{
		return null;
	}

	protected virtual void RekeyCipher(SecurityParameters securityParameters, TlsAeadCipherImpl cipher, byte[] nonce, bool serverSecret)
	{
	}

	protected virtual void Setup13Cipher(TlsAeadCipherImpl cipher, byte[] nonce, TlsSecret secret, int cryptoHashAlgorithm)
	{
	}

	private static int GetNonceMode(bool isTLSv13, int aeadType)
	{
		return 0;
	}
}
