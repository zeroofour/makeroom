using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public readonly struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	internal readonly Task m_task = null;

	public bool IsCompleted => false;

	internal TaskAwaiter(Task task)
	{
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	[StackTraceHidden]
	public void GetResult()
	{
	}

	[StackTraceHidden]
	internal static void ValidateEnd(Task task)
	{
	}

	[StackTraceHidden]
	private static void HandleNonSuccessAndDebuggerNotification(Task task)
	{
	}

	[StackTraceHidden]
	private static void ThrowForNonSuccess(Task task)
	{
	}

	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
	{
	}

	private static Action OutputWaitEtwEvents(Task task, Action continuation)
	{
		return null;
	}
}
public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task<TResult> m_task = null;

	public bool IsCompleted => false;

	internal TaskAwaiter(Task<TResult> task)
	{
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	[StackTraceHidden]
	public TResult GetResult()
	{
		return default;
	}
}
