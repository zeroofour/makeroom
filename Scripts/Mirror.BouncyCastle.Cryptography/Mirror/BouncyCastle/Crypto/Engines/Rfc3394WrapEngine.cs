using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class Rfc3394WrapEngine : IWrapper
{
	private static readonly byte[] DefaultIV;

	private readonly IBlockCipher m_engine;

	private readonly bool m_wrapCipherMode;

	private readonly byte[] m_iv;

	private KeyParameter m_key;

	private bool m_forWrapping;

	public virtual string AlgorithmName => null;

	public Rfc3394WrapEngine(IBlockCipher engine)
	{
	}

	public Rfc3394WrapEngine(IBlockCipher engine, bool useReverseDirection)
	{
	}

	public virtual void Init(bool forWrapping, ICipherParameters parameters)
	{
	}

	public virtual byte[] Wrap(byte[] input, int inOff, int inLen)
	{
		return null;
	}

	public virtual byte[] Unwrap(byte[] input, int inOff, int inLen)
	{
		return null;
	}
}
