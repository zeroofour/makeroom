using System.Collections.Generic;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class NaccacheSternEngine : IAsymmetricBlockCipher
{
	private bool forEncryption;

	private NaccacheSternKeyParameters key;

	private IList<BigInteger>[] lookup;

	public string AlgorithmName => null;

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public virtual int GetInputBlockSize()
	{
		return 0;
	}

	public virtual int GetOutputBlockSize()
	{
		return 0;
	}

	public virtual byte[] ProcessBlock(byte[] inBytes, int inOff, int length)
	{
		return null;
	}

	public virtual byte[] Encrypt(BigInteger plain)
	{
		return null;
	}

	public virtual byte[] AddCryptedBlocks(byte[] block1, byte[] block2)
	{
		return null;
	}

	public virtual byte[] ProcessData(byte[] data)
	{
		return null;
	}

	private static BigInteger ChineseRemainder(IList<BigInteger> congruences, IList<BigInteger> primes)
	{
		return null;
	}
}
