using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	internal static readonly Action<object> s_invokeActionDelegate;

	private readonly ValueTask _value = default;

	public bool IsCompleted
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ValueTaskAwaiter(ValueTask value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[StackTraceHidden]
	public void GetResult()
	{
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}
}
public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly ValueTask<TResult> _value = default;

	public bool IsCompleted
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ValueTaskAwaiter(ValueTask<TResult> value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[StackTraceHidden]
	public TResult GetResult()
	{
		return default;
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}
}
