namespace Mirror.BouncyCastle.Tls;

public abstract class MaxFragmentLength
{
	public const short pow2_9 = 1;

	public const short pow2_10 = 2;

	public const short pow2_11 = 3;

	public const short pow2_12 = 4;

	public static bool IsValid(short maxFragmentLength)
	{
		return false;
	}
}
