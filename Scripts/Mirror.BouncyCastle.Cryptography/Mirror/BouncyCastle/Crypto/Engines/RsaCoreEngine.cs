using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class RsaCoreEngine : IRsa
{
	private RsaKeyParameters m_key;

	private bool m_forEncryption;

	private int m_bitSize;

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

	public virtual BigInteger ConvertInput(byte[] inBuf, int inOff, int inLen)
	{
		return null;
	}

	public virtual byte[] ConvertOutput(BigInteger result)
	{
		return null;
	}

	public virtual BigInteger ProcessBlock(BigInteger input)
	{
		return null;
	}

	private void CheckInitialised()
	{
	}
}
