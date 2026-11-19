using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class PlainDsaEncoding : IDsaEncoding
{
	public static readonly PlainDsaEncoding Instance;

	public virtual BigInteger[] Decode(BigInteger n, byte[] encoding)
	{
		return null;
	}

	public virtual byte[] Encode(BigInteger n, BigInteger r, BigInteger s)
	{
		return null;
	}

	public virtual int GetMaxEncodingSize(BigInteger n)
	{
		return 0;
	}

	protected virtual BigInteger CheckValue(BigInteger n, BigInteger x)
	{
		return null;
	}

	protected virtual BigInteger DecodeValue(BigInteger n, byte[] buf, int off, int len)
	{
		return null;
	}

	protected virtual void EncodeValue(BigInteger n, BigInteger x, byte[] buf, int off, int len)
	{
	}
}
