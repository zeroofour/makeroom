using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

internal sealed class BikeEngine
{
	private readonly int r;

	private readonly int w;

	private readonly int hw;

	private readonly int t;

	private readonly int nbIter;

	private readonly int tau;

	private readonly BikeRing bikeRing;

	private readonly int L_BYTE;

	private readonly int R_BYTE;

	private readonly int R2_UINT;

	private readonly int R_ULONG;

	private readonly int R2_ULONG;

	internal int SessionKeySize => 0;

	internal BikeEngine(int r, int w, int t, int l, int nbIter, int tau)
	{
	}

	private ulong[] FunctionH(byte[] seed)
	{
		return null;
	}

	private void FunctionL(ulong[] e01, byte[] c1, int c1Off)
	{
	}

	private void FunctionK(byte[] m, byte[] c01, byte[] result)
	{
	}

	private void FunctionK(byte[] m, byte[] c0, byte[] c1, byte[] result)
	{
	}

	internal void GenKeyPair(byte[] h0, byte[] h1, byte[] sigma, byte[] h, SecureRandom random)
	{
	}

	internal void Encaps(byte[] c01, byte[] k, byte[] h, SecureRandom random)
	{
	}

	internal void Decaps(byte[] k, byte[] h0, byte[] h1, byte[] sigma, byte[] c0, byte[] c1)
	{
	}

	private byte[] ComputeSyndrome(byte[] c0, byte[] h0)
	{
		return null;
	}

	private byte[] BGFDecoder(byte[] s, int[] h0Compact, int[] h1Compact)
	{
		return null;
	}

	private void BFIter(byte[] s, byte[] e, int T, int[] h0Compact, int[] h1Compact, int[] h0CompactCol, int[] h1CompactCol, uint[] black, uint[] gray, byte[] ctrs)
	{
	}

	private void BFIter2(byte[] s, byte[] e, int T, int[] h0Compact, int[] h1Compact, int[] h0CompactCol, int[] h1CompactCol, uint[] black, byte[] ctrs)
	{
	}

	private void BFMaskedIter(byte[] s, byte[] e, uint[] mask, int T, int[] h0Compact, int[] h1Compact, int[] h0CompactCol, int[] h1CompactCol)
	{
	}

	private static int Threshold(int hammingWeight, int r)
	{
		return 0;
	}

	private static int ThresholdFromParameters(int hammingWeight, double dm, double da, int min)
	{
		return 0;
	}

	private int Ctr(int[] hCompactCol, byte[] s, int j)
	{
		return 0;
	}

	private void CtrAll(int[] hCompactCol, byte[] s, byte[] ctrs)
	{
	}

	private void ConvertToCompact(int[] compactVersion, byte[] h)
	{
	}

	private int[] GetColumnFromCompactVersion(int[] hCompact)
	{
		return null;
	}

	private void RecomputeSyndrome(byte[] syndrome, int index, int[] h0Compact, int[] h1Compact)
	{
	}

	private void AlignE01From1To64(ulong[] e01)
	{
	}

	private void AlignE01From64To8(ulong[] e01)
	{
	}

	private void AlignE01From8To1(ulong[] e01)
	{
	}
}
