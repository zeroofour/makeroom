namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class FpeParameters : ICipherParameters
{
	private readonly KeyParameter key;

	private readonly int radix;

	private readonly byte[] tweak;

	private readonly bool useInverse;

	public KeyParameter Key => null;

	public int Radix => 0;

	public bool UseInverseFunction => false;

	public FpeParameters(KeyParameter key, int radix, byte[] tweak)
	{
	}

	public FpeParameters(KeyParameter key, int radix, byte[] tweak, bool useInverse)
	{
	}

	public byte[] GetTweak()
	{
		return null;
	}
}
