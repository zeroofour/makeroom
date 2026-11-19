namespace Mirror.BouncyCastle.Crypto.Fpe;

public class FpeFf3_1Engine : FpeEngine
{
	public FpeFf3_1Engine()
		: base(null)
	{
	}

	public FpeFf3_1Engine(IBlockCipher baseCipher)
		: base(null)
	{
	}

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	protected override int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		return 0;
	}

	protected override int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
	{
		return 0;
	}
}
