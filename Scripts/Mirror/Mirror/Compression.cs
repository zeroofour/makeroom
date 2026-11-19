using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public static class Compression
{
	private const float QuaternionMinRange = -0.707107f;

	private const float QuaternionMaxRange = 0.707107f;

	private const ushort TenBitsMax = 1023;

	public static bool ScaleToLong(float value, float precision, out long result)
	{
		result = default;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool ScaleToLong(Vector3 value, float precision, out long x, out long y, out long z)
	{
		x = default;
		y = default;
		z = default;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool ScaleToLong(Quaternion value, float precision, out long x, out long y, out long z, out long w)
	{
		x = default;
		y = default;
		z = default;
		w = default;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool ScaleToLong(Vector3 value, float precision, out Vector3Long quantized)
	{
		quantized = default;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool ScaleToLong(Quaternion value, float precision, out Vector4Long quantized)
	{
		quantized = default;
		return false;
	}

	public static float ScaleToFloat(long value, float precision)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ScaleToFloat(long x, long y, long z, float precision)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion ScaleToFloat(long x, long y, long z, long w, float precision)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ScaleToFloat(Vector3Long value, float precision)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion ScaleToFloat(Vector4Long value, float precision)
	{
		return default;
	}

	public static ushort ScaleFloatToUShort(float value, float minValue, float maxValue, ushort minTarget, ushort maxTarget)
	{
		return 0;
	}

	public static float ScaleUShortToFloat(ushort value, ushort minValue, ushort maxValue, float minTarget, float maxTarget)
	{
		return 0f;
	}

	public static int LargestAbsoluteComponentIndex(Vector4 value, out float largestAbs, out Vector3 withoutLargest)
	{
		largestAbs = default;
		withoutLargest = default;
		return 0;
	}

	public static uint CompressQuaternion(Quaternion q)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static Quaternion QuaternionNormalizeSafe(Quaternion value)
	{
		return default;
	}

	public static Quaternion DecompressQuaternion(uint data)
	{
		return default;
	}

	public static int VarUIntSize(ulong value)
	{
		return 0;
	}

	public static int VarIntSize(long value)
	{
		return 0;
	}

	public static void CompressVarUInt(NetworkWriter writer, ulong value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CompressVarInt(NetworkWriter writer, long i)
	{
	}

	public static ulong DecompressVarUInt(NetworkReader reader)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long DecompressVarInt(NetworkReader reader)
	{
		return 0L;
	}
}
