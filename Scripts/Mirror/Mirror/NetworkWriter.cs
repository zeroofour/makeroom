using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mirror;

public class NetworkWriter
{
	public const ushort MaxStringLength = 65534;

	public const int DefaultCapacity = 1500;

	internal byte[] buffer;

	public int Position;

	internal readonly UTF8Encoding encoding;

	public int Capacity => 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void EnsureCapacity(int value)
	{
	}

	public byte[] ToArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ArraySegment<byte> ToArraySegment()
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator ArraySegment<byte>(NetworkWriter w)
	{
		return default;
	}

	internal void WriteBlittable<T>(T value) where T : struct
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void WriteBlittableNullable<T>(T? value) where T : struct
	{
	}

	public void WriteByte(byte value)
	{
	}

	public void WriteBytes(byte[] array, int offset, int count)
	{
	}

	public unsafe bool WriteBytes(byte* ptr, int offset, int size)
	{
		return false;
	}

	public void Write<T>(T value)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
