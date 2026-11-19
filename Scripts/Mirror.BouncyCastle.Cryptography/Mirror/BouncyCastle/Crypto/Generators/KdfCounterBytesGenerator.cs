namespace Mirror.BouncyCastle.Crypto.Generators;

public sealed class KdfCounterBytesGenerator : IMacDerivationFunction, IDerivationFunction
{
	private readonly IMac prf;

	private readonly int h;

	private byte[] fixedInputDataCtrPrefix;

	private byte[] fixedInputData_afterCtr;

	private int maxSizeExcl;

	private byte[] ios;

	private int generatedBytes;

	private byte[] k;

	public IMac Mac => null;

	public IDigest Digest => null;

	public KdfCounterBytesGenerator(IMac prf)
	{
	}

	public void Init(IDerivationParameters param)
	{
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		return 0;
	}

	private void GenerateNext()
	{
	}
}
