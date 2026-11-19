using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class Rfc5649WrapEngine : IWrapper
{
	private static readonly byte[] DefaultIV;

	private readonly IBlockCipher m_engine;

	private readonly byte[] m_preIV;

	private KeyParameter m_key;

	private bool m_forWrapping;

	public virtual string AlgorithmName => null;

	public Rfc5649WrapEngine(IBlockCipher engine)
	{
	}

	public virtual void Init(bool forWrapping, ICipherParameters parameters)
	{
	}

	public virtual byte[] Wrap(byte[] input, int inOff, int length)
	{
		return null;
	}

	public virtual byte[] Unwrap(byte[] input, int inOff, int length)
	{
		return null;
	}

	private byte[] Rfc3394UnwrapNoIvCheck(byte[] input, int inOff, int inLen, byte[] extractedAIV)
	{
		return null;
	}

	private static byte[] PadPlaintext(byte[] plaintext)
	{
		return null;
	}
}
