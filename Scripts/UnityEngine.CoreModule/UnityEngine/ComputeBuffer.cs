using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeClass("GraphicsBuffer")]
[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
public sealed class ComputeBuffer : IDisposable
{
	internal IntPtr m_Ptr;

	public int count => 0;

	~ComputeBuffer()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
	{
		return (IntPtr)0;
	}

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(ComputeBuffer buf)
	{
	}

	public ComputeBuffer(int count, int stride)
	{
	}

	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
	{
	}

	public void Release()
	{
	}
}
