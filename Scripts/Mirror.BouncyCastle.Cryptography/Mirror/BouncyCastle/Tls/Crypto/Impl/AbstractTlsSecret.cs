namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public abstract class AbstractTlsSecret : TlsSecret
{
	protected byte[] m_data;

	protected abstract AbstractTlsCrypto Crypto { get; }

	public virtual int Length => 0;

	protected static byte[] CopyData(AbstractTlsSecret other)
	{
		return null;
	}

	protected AbstractTlsSecret(byte[] data)
	{
	}

	protected virtual void CheckAlive()
	{
	}

	public virtual byte[] CalculateHmac(int cryptoHashAlgorithm, byte[] buf, int off, int len)
	{
		return null;
	}

	public abstract TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length);

	public virtual void Destroy()
	{
	}

	public virtual byte[] Encrypt(TlsEncryptor encryptor)
	{
		return null;
	}

	public virtual byte[] Extract()
	{
		return null;
	}

	public abstract TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length);

	public abstract TlsSecret HkdfExtract(int cryptoHashAlgorithm, TlsSecret ikm);

	public virtual bool IsAlive()
	{
		return false;
	}

	internal virtual byte[] CopyData()
	{
		return null;
	}
}
