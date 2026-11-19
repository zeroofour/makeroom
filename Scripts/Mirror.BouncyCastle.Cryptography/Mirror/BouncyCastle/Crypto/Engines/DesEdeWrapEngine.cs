using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class DesEdeWrapEngine : IWrapper
{
	private CbcBlockCipher engine;

	private KeyParameter param;

	private ParametersWithIV paramPlusIV;

	private byte[] iv;

	private bool forWrapping;

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

	private byte[] CalculateCmsKeyChecksum(byte[] key)
	{
		return null;
	}

	private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
	{
		return false;
	}
}
