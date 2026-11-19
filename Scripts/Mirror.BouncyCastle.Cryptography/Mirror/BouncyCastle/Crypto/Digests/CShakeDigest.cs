namespace Mirror.BouncyCastle.Crypto.Digests;

public class CShakeDigest : ShakeDigest
{
	private static readonly byte[] padding;

	private readonly byte[] diff;

	public override string AlgorithmName => null;

	private static byte[] EncodeString(byte[] str)
	{
		return null;
	}

	public CShakeDigest(int bitLength, byte[] N, byte[] S)
	{
	}

	public CShakeDigest(CShakeDigest source)
	{
	}

	private void DiffPadAndAbsorb()
	{
	}

	public override int Output(byte[] output, int outOff, int outLen)
	{
		return 0;
	}

	public override void Reset()
	{
	}
}
