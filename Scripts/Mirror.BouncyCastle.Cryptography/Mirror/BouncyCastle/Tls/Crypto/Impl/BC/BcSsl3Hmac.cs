using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal class BcSsl3Hmac : TlsHmac, TlsMac
{
	private const byte IPAD_BYTE = 54;

	private const byte OPAD_BYTE = 92;

	private static readonly byte[] IPAD;

	private static readonly byte[] OPAD;

	private readonly IDigest m_digest;

	private readonly int m_padLength;

	private byte[] m_secret;

	public virtual int InternalBlockSize => 0;

	public virtual int MacLength => 0;

	internal BcSsl3Hmac(IDigest digest)
	{
	}

	public virtual void SetKey(byte[] key, int keyOff, int keyLen)
	{
	}

	public virtual void Update(byte[] input, int inOff, int len)
	{
	}

	public virtual byte[] CalculateMac()
	{
		return null;
	}

	public virtual void CalculateMac(byte[] output, int outOff)
	{
	}

	public virtual void Reset()
	{
	}

	private void DoFinal(byte[] output, int outOff)
	{
	}

	private static byte[] GenPad(byte b, int count)
	{
		return null;
	}
}
