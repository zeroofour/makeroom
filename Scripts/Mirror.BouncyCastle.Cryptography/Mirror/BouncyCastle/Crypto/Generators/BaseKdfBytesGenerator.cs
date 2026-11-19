namespace Mirror.BouncyCastle.Crypto.Generators;

public abstract class BaseKdfBytesGenerator : IDerivationFunction
{
	private int counterStart;

	private IDigest digest;

	private byte[] shared;

	private byte[] iv;

	public IDigest Digest => null;

	protected BaseKdfBytesGenerator(int counterStart, IDigest digest)
	{
	}

	public void Init(IDerivationParameters parameters)
	{
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		return 0;
	}
}
