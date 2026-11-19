using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class RC2WrapEngine : IWrapper
{
	private CbcBlockCipher engine;

	private ICipherParameters parameters;

	private ParametersWithIV paramPlusIV;

	private byte[] iv;

	private bool forWrapping;

	private SecureRandom sr;

	private static readonly byte[] IV2;

	private readonly IDigest sha1;

	private readonly byte[] digest;

	public virtual string AlgorithmName => null;

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

	private void CalculateCmsKeyChecksum(byte[] key, int keyOff, int keyLen, byte[] cks, int cksOff)
	{
	}

	private bool CheckCmsKeyChecksum(byte[] key, int keyOff, int keyLen, byte[] cks, int cksOff)
	{
		return false;
	}
}
