using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mirror;

public class NetworkReader
{
	internal ArraySegment<byte> buffer;

	public int Position;

	internal readonly UTF8Encoding encoding;

	public const int AllocationLimit = 16777216;

	public int Remaining => 0;

	public int Capacity => 0;

	public NetworkReader(ArraySegment<byte> segment)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetBuffer(ArraySegment<byte> segment)
	{
	}

	internal T ReadBlittable<T>() where T : struct
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal T? ReadBlittableNullable<T>() where T : struct
	{
		return null;
	}

	public byte ReadByte()
	{
		return 0;
	}

	public byte[] ReadBytes(byte[] bytes, int count)
	{
		return null;
	}

	public ArraySegment<byte> ReadBytesSegment(int count)
	{
		return default;
	}

	public T Read<T>()
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
