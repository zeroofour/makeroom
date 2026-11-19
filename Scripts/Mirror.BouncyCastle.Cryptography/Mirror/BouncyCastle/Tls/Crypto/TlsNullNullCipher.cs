namespace Mirror.BouncyCastle.Tls.Crypto;

public sealed class TlsNullNullCipher : TlsCipher
{
	public static readonly TlsNullNullCipher Instance;

	public bool UsesOpaqueRecordType => false;

	public int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return 0;
	}

	public int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		return 0;
	}

	public int GetPlaintextLimit(int ciphertextLimit)
	{
		return 0;
	}

	public TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		return null;
	}

	public TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		return null;
	}

	public void RekeyDecoder()
	{
	}

	public void RekeyEncoder()
	{
	}
}
