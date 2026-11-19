using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror;

public class SyncSet<T> : SyncObject, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public enum Operation : byte
	{
		OP_ADD = 0,
		OP_REMOVE = 1,
		OP_CLEAR = 2
	}

	private struct Change
	{
		internal Operation operation;

		internal T item;
	}

	public Action<T> OnAdd;

	public Action<T> OnRemove;

	public Action OnClear;

	public Action<Operation, T> OnChange;

	protected readonly ISet<T> objects;

	private readonly List<Change> changes;

	private int changesAhead;

	public int Count => 0;

	public bool IsReadOnly => false;

	public SyncSet(ISet<T> objects)
	{
	}

	public override void Reset()
	{
	}

	public override void ClearChanges()
	{
	}

	private void AddOperation(Operation op, T oldItem, T newItem, bool checkAccess)
	{
	}

	private void AddOperation(Operation op, bool checkAccess)
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

	public bool Add(T item)
	{
		return false;
	}

	void ICollection<T>.Add(T item)
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

	public bool Remove(T item)
	{
		return false;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void ExceptWith(IEnumerable<T> other)
	{
	}

	public void IntersectWith(IEnumerable<T> other)
	{
	}

	private void IntersectWithSet(ISet<T> otherSet)
	{
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		return false;
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		return false;
	}

	public void SymmetricExceptWith(IEnumerable<T> other)
	{
	}

	public void UnionWith(IEnumerable<T> other)
	{
	}
}
