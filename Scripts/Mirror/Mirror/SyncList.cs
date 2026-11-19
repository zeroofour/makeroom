using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror;

public class SyncList<T> : SyncObject, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	public enum Operation : byte
	{
		OP_ADD = 0,
		OP_SET = 1,
		OP_INSERT = 2,
		OP_REMOVEAT = 3,
		OP_CLEAR = 4
	}

	private struct Change
	{
		internal Operation operation;

		internal int index;

		internal T item;
	}

	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private readonly SyncList<T> list = null;

		private int index = 0;

		public T Current { get; private set; } = default;

		object IEnumerator.Current => null;

		public Enumerator(SyncList<T> list)
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

	public Action<int> OnAdd;

	public Action<int> OnInsert;

	public Action<int, T> OnSet;

	public Action<int, T> OnRemove;

	public Action OnClear;

	public Action<Operation, int, T> OnChange;

	public Action<Operation, int, T, T> Callback;

	private readonly IList<T> objects;

	private readonly IEqualityComparer<T> comparer;

	private readonly List<Change> changes;

	private int changesAhead;

	public int Count => 0;

	public bool IsReadOnly => false;

	public T this[int i]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SyncList()
	{
	}

	public SyncList(IEqualityComparer<T> comparer)
	{
	}

	public SyncList(IList<T> objects, IEqualityComparer<T> comparer = null)
	{
	}

	public override void ClearChanges()
	{
	}

	public override void Reset()
	{
	}

	private void AddOperation(Operation op, int itemIndex, T oldItem, T newItem, bool checkAccess)
	{
	}

	public override void OnSerializeAll(NetworkWriter writer)
	{
	}

	public override void OnSerializeDelta(NetworkWriter writer)
	{
	}

	public override void OnDeserializeAll(NetworkReader reader)
	{
	}

	public override void OnDeserializeDelta(NetworkReader reader)
	{
	}

	public void Add(T item)
	{
	}

	public void AddRange(IEnumerable<T> range)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int index)
	{
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public int FindIndex(Predicate<T> match)
	{
		return 0;
	}

	public T Find(Predicate<T> match)
	{
		return default;
	}

	public List<T> FindAll(Predicate<T> match)
	{
		return null;
	}

	public void Insert(int index, T item)
	{
	}

	public void InsertRange(int index, IEnumerable<T> range)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public int RemoveAll(Predicate<T> match)
	{
		return 0;
	}

	public Enumerator GetEnumerator()
	{
		return default;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
