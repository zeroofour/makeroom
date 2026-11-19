using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Concurrent;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
public class ConcurrentBag<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	private sealed class WorkStealingQueue
	{
		private int _headIndex;

		private int _tailIndex;

		private T[] _array;

		private int _mask;

		private int _addTakeCount;

		private int _stealCount;

		internal int _currentOp;

		internal bool _frozen;

		internal readonly WorkStealingQueue _nextQueue;

		internal readonly int _ownerThreadId;

		internal int DangerousCount => 0;

		internal WorkStealingQueue(WorkStealingQueue nextQueue)
		{
		}

		internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount)
		{
		}

		internal bool TryLocalPop(out T result)
		{
			result = default;
			return false;
		}

		internal bool TrySteal(out T result, bool take)
		{
			result = default;
			return false;
		}

		internal int DangerousCopyTo(T[] array, int arrayIndex)
		{
			return 0;
		}
	}

	[Serializable]
	private sealed class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly T[] _array;

		private T _current;

		private int _index;

		public T Current => default;

		object IEnumerator.Current => null;

		public Enumerator(T[] array)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	private readonly ThreadLocal<WorkStealingQueue> _locals;

	private WorkStealingQueue _workStealingQueues;

	private long _emptyToNonEmptyListTransitionCount;

	public int Count => 0;

	private int DangerousCount => 0;

	object ICollection.SyncRoot => null;

	private object GlobalQueuesLock => null;

	public void Add(T item)
	{
	}

	public bool TryTake(out T result)
	{
		result = default;
		return false;
	}

	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate)
	{
		return null;
	}

	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread()
	{
		return null;
	}

	private WorkStealingQueue GetUnownedWorkStealingQueue()
	{
		return null;
	}

	private bool TrySteal(out T result, bool take)
	{
		result = default;
		return false;
	}

	private bool TryStealFromTo(WorkStealingQueue startInclusive, WorkStealingQueue endExclusive, out T result, bool take)
	{
		result = default;
		return false;
	}

	public void CopyTo(T[] array, int index)
	{
	}

	private int CopyFromEachQueueToArray(T[] array, int index)
	{
		return 0;
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	public T[] ToArray()
	{
		return null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private void FreezeBag(ref bool lockTaken)
	{
	}

	private void UnfreezeBag(bool lockTaken)
	{
	}
}
