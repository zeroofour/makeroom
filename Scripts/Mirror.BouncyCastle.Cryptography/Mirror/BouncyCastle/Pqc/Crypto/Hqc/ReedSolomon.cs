namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

internal class ReedSolomon
{
	private static int[,] alpha128;

	private static int[,] alpha192;

	private static int[,] alpha256;

	private static int[] logArrays;

	private static int[] expArrays;

	internal static void Encode(byte[] codeWord, byte[] message, int mBitSize, int n1, int paramK, int paramG, int[] rsPoly)
	{
	}

	internal static void Decode(byte[] message, byte[] codeWord, int n1, int fft, int delta, int paramK, int paramG)
	{
	}

	private static void ComputeSyndromes(int[] syndromes, byte[] codeWord, int delta, int n1)
	{
	}

	private static int ComputeELP(int[] sigma, int[] syndromes, int delta)
	{
		return 0;
	}

	private static void ComputeZx(int[] output, int[] sigma, int deg, int[] syndromes, int delta)
	{
	}

	private static void ComputeErrors(int[] res, int[] zx, byte[] errorCompactSet, int delta, int n1)
	{
	}
}
