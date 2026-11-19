using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

public readonly struct ConfiguredTaskAwaitable
{
	public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		internal readonly Task m_task = null;

		internal readonly bool m_continueOnCapturedContext = false;

		public bool IsCompleted => false;

		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
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
	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter = default;

	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
	{
	}

	public ConfiguredTaskAwaiter GetAwaiter()
	{
		return default;
	}
}
public readonly struct ConfiguredTaskAwaitable<TResult>
{
	public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task<TResult> m_task = null;

		private readonly bool m_continueOnCapturedContext = false;

		public bool IsCompleted => false;

		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
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

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter = default;

	internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
	{
	}

	public ConfiguredTaskAwaiter GetAwaiter()
	{
		return default;
	}
}
