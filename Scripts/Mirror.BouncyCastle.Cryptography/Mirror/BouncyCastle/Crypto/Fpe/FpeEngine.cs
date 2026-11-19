using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Fpe;

public abstract class FpeEngine
{
	protected readonly IBlockCipher baseCipher;

	protected bool forEncryption;

	protected FpeParameters fpeParameters;

	protected FpeEngine(IBlockCipher baseCipher)
	{
	}

	public virtual int ProcessBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		return 0;
	}

	protected static bool IsOverrideSet(string propName)
	{
		return false;
	}

	public abstract void Init(bool forEncryption, ICipherParameters parameters);

	protected abstract int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);

	protected abstract int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);
}
