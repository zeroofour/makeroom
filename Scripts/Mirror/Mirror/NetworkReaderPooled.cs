using System;

namespace Mirror;

public sealed class NetworkReaderPooled : NetworkReader, IDisposable
{
	internal NetworkReaderPooled(byte[] bytes)
		: base(default)
	{
	}

	internal NetworkReaderPooled(ArraySegment<byte> segment)
		: base(default)
	{
	}

	public void Dispose()
	{
	}
}
