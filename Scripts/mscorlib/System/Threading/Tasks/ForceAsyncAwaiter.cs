using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

internal readonly struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task _task = null;

	public bool IsCompleted => false;

	internal ForceAsyncAwaiter(Task task)
	{
	}

	public ForceAsyncAwaiter GetAwaiter()
	{
		return default;
	}

	public void GetResult()
	{
	}

	public void OnCompleted(Action action)
	{
	}

	public void UnsafeOnCompleted(Action action)
	{
	}
}
