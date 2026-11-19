using System;

namespace Mirror.BouncyCastle.Utilities;

public static class Longs
{
	public const int NumBits = 64;

	public const int NumBytes = 8;

	private static readonly byte[] DeBruijnTZ;

	public static long HighestOneBit(long i)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong HighestOneBit(ulong i)
	{
		return 0uL;
	}

	public static long LowestOneBit(long i)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong LowestOneBit(ulong i)
	{
		return 0uL;
	}

	public static int NumberOfLeadingZeros(long i)
	{
		return 0;
	}

	public static int NumberOfTrailingZeros(long i)
	{
		return 0;
	}

	public static long Reverse(long i)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong Reverse(ulong i)
	{
		return 0uL;
	}

	public static long ReverseBytes(long i)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong ReverseBytes(ulong i)
	{
		return 0uL;
	}

	public static long RotateLeft(long i, int distance)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong RotateLeft(ulong i, int distance)
	{
		return 0uL;
	}

	public static long RotateRight(long i, int distance)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ulong RotateRight(ulong i, int distance)
	{
		return 0uL;
	}
}
