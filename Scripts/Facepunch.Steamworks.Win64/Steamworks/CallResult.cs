using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks;

internal struct CallResult<T>(SteamAPICall_t call, bool server) : INotifyCompletion where T : struct, ICallbackData
{
	private SteamAPICall_t call = default;

	private ISteamUtils utils = null;

	private bool server = false;

	public bool IsCompleted => false;

	public void OnCompleted(Action continuation)
	{
	}

	public T? GetResult()
	{
		return null;
	}

	internal CallResult<T> GetAwaiter()
	{
		return default;
	}
}
