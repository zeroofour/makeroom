using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror;

public class SyncIDictionary<TKey, TValue> : SyncObject, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	public enum Operation : byte
	{
		OP_ADD = 0,
		OP_SET = 1,
		OP_REMOVE = 2,
		OP_CLEAR = 3
	}

	private struct Change
	{
		internal Operation operation;

		internal TKey key;

		internal TValue item;
	}

	public Action<TKey> OnAdd;

	public Action<TKey, TValue> OnSet;

	public Action<TKey, TValue> OnRemove;

	public Action OnClear;

	public Action<Operation, TKey, TValue> OnChange;

	protected readonly IDictionary<TKey, TValue> objects;

	private readonly List<Change> changes;

	private int changesAhead;

	public int Count => 0;

	public bool IsReadOnly => false;

	public ICollection<TKey> Keys => null;

	public ICollection<TValue> Values => null;

	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

	public TValue this[TKey i]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SyncIDictionary(IDictionary<TKey, TValue> objects)
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

	public override void ClearChanges()
	{
	}

	public override void Reset()
	{
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default;
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public void Clear()
	{
	}

	private void AddOperation(Operation op, TKey key, TValue item, TValue oldItem, bool checkAccess)
	{
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
