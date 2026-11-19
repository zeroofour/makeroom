namespace Mirror.BouncyCastle.Crypto.Generators;

public sealed class KdfDoublePipelineIterationBytesGenerator : IMacDerivationFunction, IDerivationFunction
{
	private readonly IMac prf;

	private readonly int h;

	private byte[] fixedInputData;

	private int maxSizeExcl;

	private byte[] ios;

	private bool useCounter;

	private int generatedBytes;

	private byte[] a;

	private byte[] k;

	public IMac Mac => null;

	public IDigest Digest => null;

	public KdfDoublePipelineIterationBytesGenerator(IMac prf)
	{
	}

	public void Init(IDerivationParameters parameters)
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
