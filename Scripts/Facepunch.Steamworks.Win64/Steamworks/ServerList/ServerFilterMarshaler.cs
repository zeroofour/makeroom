using System;
using Steamworks.Data;

namespace Steamworks.ServerList;

internal struct ServerFilterMarshaler : IDisposable
{
	private static readonly int SizeOfPointer;

	private static readonly int SizeOfKeyValuePair;

	private IntPtr _arrayPtr = (IntPtr)0;

	private IntPtr _itemsPtr = (IntPtr)0;

	public int Count { get; private set; } = 0;

	public IntPtr Pointer => (IntPtr)0;

	public ServerFilterMarshaler(MatchMakingKeyValuePair[] filters)
	{
	}

	public void Dispose()
	{
	}
}
