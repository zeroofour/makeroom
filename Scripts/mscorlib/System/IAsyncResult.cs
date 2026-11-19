using System.Threading;

namespace System;

public interface IAsyncResult
{
	WaitHandle AsyncWaitHandle { get; }

	object AsyncState { get; }

	bool CompletedSynchronously { get; }
}
