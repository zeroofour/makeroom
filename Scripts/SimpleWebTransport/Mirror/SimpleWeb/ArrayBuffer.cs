using System;
using System.Diagnostics;

namespace Mirror.SimpleWeb;

public sealed class ArrayBuffer : IDisposable
{
	private readonly IBufferOwner owner;

	public readonly byte[] array;

	private int releasesRequired;

	public int count { get; internal set; }

	public void SetReleasesRequired(int required)
	{
	}

	public ArrayBuffer(IBufferOwner owner, int size)
	{
	}

	public void Release()
	{
	}

	public void Dispose()
	{
	}

	public void CopyTo(byte[] target, int offset)
	{
	}

	public void CopyFrom(ArraySegment<byte> segment)
	{
	}

	public void CopyFrom(byte[] source, int offset, int length)
	{
	}

	public void CopyFrom(IntPtr bufferPtr, int length)
	{
	}

	public ArraySegment<byte> ToSegment()
	{
		return default;
	}

	[Conditional("UNITY_ASSERTIONS")]
	internal void Validate(int arraySize)
	{
	}
}
