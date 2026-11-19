namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

internal class ReedMuller
{
	internal class Codeword
	{
		internal int[] type32;

		internal int[] type8;
	}

	private static void EncodeSub(Codeword codeword, int m)
	{
	}

	private static void HadamardTransform(int[] srcCode, int[] desCode)
	{
	}

	private static void ExpandThenSum(int[] desCode, Codeword[] srcCode, int off, int mulParam)
	{
	}

	private static int FindPeaks(int[] input)
	{
		return 0;
	}

	private static int Bit0Mask(int b)
	{
		return 0;
	}

	public static void Encode(long[] codeword, byte[] m, int n1, int mulParam)
	{
	}

	public static void Decode(byte[] m, long[] codeword, int n1, int mulParam)
	{
	}
}
