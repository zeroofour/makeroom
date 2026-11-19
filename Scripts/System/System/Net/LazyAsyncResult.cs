namespace System.Net;

internal class LazyAsyncResult
{
	private class ThreadContext
	{
		internal int m_NestedIOCount;
	}

	[ThreadStatic]
	private static ThreadContext t_ThreadContext;

	private object m_AsyncObject;

	private AsyncCallback m_AsyncCallback;

	private object m_Result;

	private int m_IntCompleted;

	private object m_Event;

	private static ThreadContext CurrentThreadContext => null;

	internal object AsyncObject => null;

	protected void ProtectedInvokeCallback(object result, IntPtr userToken)
	{
	}

	internal void InvokeCallback(object result)
	{
	}

	protected virtual void Complete(IntPtr userToken)
	{
	}

	private void WorkerThreadComplete(object state)
	{
	}

	protected virtual void Cleanup()
	{
	}
}
