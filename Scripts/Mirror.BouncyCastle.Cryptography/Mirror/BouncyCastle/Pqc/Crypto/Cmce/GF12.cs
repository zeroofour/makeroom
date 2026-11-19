using System.Runtime.InteropServices;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct GF12 : GF
{
	public void GFMulPoly(int length, int[] poly, ushort[] output, ushort[] left, ushort[] right, uint[] temp)
	{
	}

	public void GFSqrPoly(int length, int[] poly, ushort[] output, ushort[] input, uint[] temp)
	{
	}

	public ushort GFFrac(ushort den, ushort num)
	{
		return 0;
	}

	public ushort GFInv(ushort input)
	{
		return 0;
	}

	public ushort GFIsZero(ushort a)
	{
		return 0;
	}

	public ushort GFMul(ushort left, ushort right)
	{
		return 0;
	}

	public uint GFMulExt(ushort left, ushort right)
	{
		return 0u;
	}

	private uint GFMulExtPar(ushort left0, ushort right0, ushort left1, ushort right1)
	{
		return 0u;
	}

	public ushort GFReduce(uint x)
	{
		return 0;
	}

	public ushort GFSq(ushort input)
	{
		return 0;
	}

	public uint GFSqExt(ushort input)
	{
		return 0u;
	}
}
