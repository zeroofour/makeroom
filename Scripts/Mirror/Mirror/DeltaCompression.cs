using System.Runtime.CompilerServices;

namespace Mirror;

public static class DeltaCompression
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Compress(NetworkWriter writer, long last, long current)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Decompress(NetworkReader reader, long last)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Compress(NetworkWriter writer, Vector3Long last, Vector3Long current)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Compress(NetworkWriter writer, Vector4Long last, Vector4Long current)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long Decompress(NetworkReader reader, Vector3Long last)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4Long Decompress(NetworkReader reader, Vector4Long last)
	{
		return default;
	}
}
