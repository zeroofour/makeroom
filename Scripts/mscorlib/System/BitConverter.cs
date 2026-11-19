using System.Runtime.CompilerServices;

namespace System;

public static class BitConverter
{
	[Intrinsic]
	public static readonly bool IsLittleEndian;

	public static byte[] GetBytes(int value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static bool TryWriteBytes(Span<byte> destination, uint value)
	{
		return false;
	}

	public static int ToInt32(byte[] value, int startIndex)
	{
		return 0;
	}

	public static long ToInt64(byte[] value, int startIndex)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(byte[] value, int startIndex)
	{
		return 0u;
	}

	public static string ToString(byte[] value, int startIndex, int length)
	{
		return null;
	}

	public static string ToString(byte[] value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long DoubleToInt64Bits(double value)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SingleToInt32Bits(float value)
	{
		return 0;
	}

	static BitConverter()
	{
	}
}
