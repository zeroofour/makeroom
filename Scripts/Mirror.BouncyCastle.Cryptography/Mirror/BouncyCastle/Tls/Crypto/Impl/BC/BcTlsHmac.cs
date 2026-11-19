using Mirror.BouncyCastle.Crypto.Macs;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsHmac : TlsHmac, TlsMac
{
	private readonly HMac m_hmac;

	public int InternalBlockSize => 0;

	public int MacLength => 0;

	internal BcTlsHmac(HMac hmac)
	{
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
	}

	public void Update(byte[] input, int inOff, int length)
	{
	}

	public byte[] CalculateMac()
	{
		return null;
	}

	public void CalculateMac(byte[] output, int outOff)
	{
	}

	public void Reset()
	{
	}
}
