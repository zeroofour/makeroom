using System;

namespace Mirror.BouncyCastle.Utilities;

public static class Integers
{
	public const int NumBits = 32;

	public const int NumBytes = 4;

	private static readonly byte[] DeBruijnTZ;

	public static int HighestOneBit(int i)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint HighestOneBit(uint i)
	{
		return 0u;
	}

	public static int LowestOneBit(int i)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint LowestOneBit(uint i)
	{
		return 0u;
	}

	public static int NumberOfLeadingZeros(int i)
	{
		return 0;
	}

	public static int NumberOfTrailingZeros(int i)
	{
		return 0;
	}

	public static int PopCount(int i)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static int PopCount(uint u)
	{
		return 0;
	}

	public static int Reverse(int i)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint Reverse(uint i)
	{
		return 0u;
	}

	public static int ReverseBytes(int i)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint ReverseBytes(uint i)
	{
		return 0u;
	}

	public static int RotateLeft(int i, int distance)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint RotateLeft(uint i, int distance)
	{
		return 0u;
	}

	public static int RotateRight(int i, int distance)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint RotateRight(uint i, int distance)
	{
		return 0u;
	}
}
