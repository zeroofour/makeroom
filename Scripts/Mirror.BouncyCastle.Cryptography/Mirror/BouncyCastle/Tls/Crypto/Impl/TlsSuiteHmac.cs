namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public class TlsSuiteHmac : TlsSuiteMac
{
	private const long SequenceNumberPlaceholder = -1L;

	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly TlsHmac m_mac;

	protected readonly int m_digestBlockSize;

	protected readonly int m_digestOverhead;

	protected readonly int m_macSize;

	public virtual int Size => 0;

	protected static int GetMacSize(TlsCryptoParameters cryptoParams, TlsMac mac)
	{
		return 0;
	}

	public TlsSuiteHmac(TlsCryptoParameters cryptoParams, TlsHmac mac)
	{
	}

	public virtual byte[] CalculateMac(long seqNo, short type, byte[] msg, int msgOff, int msgLen)
	{
		return null;
	}

	public virtual byte[] CalculateMac(long seqNo, short type, byte[] connectionID, byte[] msg, int msgOff, int msgLen)
	{
		return null;
	}

	public virtual byte[] CalculateMacConstantTime(long seqNo, short type, byte[] msg, int msgOff, int msgLen, int fullLength, byte[] dummyData)
	{
		return null;
	}

	public virtual byte[] CalculateMacConstantTime(long seqNo, short type, byte[] connectionID, byte[] msg, int msgOff, int msgLen, int fullLength, byte[] dummyData)
	{
		return null;
	}

	protected virtual int GetDigestBlockCount(int inputLength)
	{
		return 0;
	}

	protected virtual int GetHeaderLength(byte[] connectionID)
	{
		return 0;
	}

	protected virtual byte[] Truncate(byte[] bs)
	{
		return null;
	}
}
