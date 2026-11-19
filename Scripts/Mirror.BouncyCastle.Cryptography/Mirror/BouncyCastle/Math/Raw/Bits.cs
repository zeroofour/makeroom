using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Math.Raw;

internal static class Bits
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static uint BitPermuteStep(uint x, uint m, int s)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ulong BitPermuteStep(ulong x, ulong m, int s)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void BitPermuteStep2(ref uint hi, ref uint lo, uint m, int s)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void BitPermuteStep2(ref ulong hi, ref ulong lo, ulong m, int s)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static uint BitPermuteStepSimple(uint x, uint m, int s)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ulong BitPermuteStepSimple(ulong x, ulong m, int s)
	{
		return 0uL;
	}
}
