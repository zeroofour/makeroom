using System.Runtime.InteropServices;

namespace System.Buffers;

public unsafe struct MemoryHandle(void* pointer, GCHandle handle = default(GCHandle), IPinnable pinnable = null) : IDisposable
{
	private unsafe void* _pointer = null;

	private GCHandle _handle = default;

	private IPinnable _pinnable = null;

	[CLSCompliant(false)]
	public unsafe void* Pointer => null;

	public void Dispose()
	{
	}
}
