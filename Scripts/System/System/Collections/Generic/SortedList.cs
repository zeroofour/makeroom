using System.Diagnostics;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	[Serializable]
	private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private SortedList<TKey, TValue> _sortedList = null;

		private TKey _key = default;

		private TValue _value = default;

		private int _index = 0;

		private int _version = 0;

		private int _getEnumeratorRetType = 0;

		object IDictionaryEnumerator.Key => null;

		DictionaryEntry IDictionaryEnumerator.Entry => default;

		public KeyValuePair<TKey, TValue> Current => default;

		object IEnumerator.Current => null;

		object IDictionaryEnumerator.Value => null;

		internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
	{
		private SortedList<TKey, TValue> _sortedList;

		private int _index;

		private int _version;

		private TKey _currentKey;

		public TKey Current => default;

		object IEnumerator.Current => null;

		internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
	{
		private SortedList<TKey, TValue> _sortedList;

		private int _index;

		private int _version;

		private TValue _currentValue;

		public TValue Current => default;

		object IEnumerator.Current => null;

		internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
	private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
	{
		private SortedList<TKey, TValue> _dict;

		public int Count => 0;

		public bool IsReadOnly => false;

		object ICollection.SyncRoot => null;

		public TKey this[int index]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal KeyList(SortedList<TKey, TValue> dictionary)
		{
		}

		public void Add(TKey key)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public void CopyTo(TKey[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		public void Insert(int index, TKey value)
		{
		}

		public IEnumerator<TKey> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(TKey key)
		{
			return 0;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
	private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
	{
		private SortedList<TKey, TValue> _dict;

		public int Count => 0;

		public bool IsReadOnly => false;

		object ICollection.SyncRoot => null;

		public TValue this[int index]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal ValueList(SortedList<TKey, TValue> dictionary)
		{
		}

		public void Add(TValue key)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TValue value)
		{
			return false;
		}

		public void CopyTo(TValue[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public void Insert(int index, TValue value)
		{
		}

		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(TValue value)
		{
			return 0;
		}

		public bool Remove(TValue value)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}
	}

	private TKey[] keys;

	private TValue[] values;

	private int _size;

	private int version;

	private IComparer<TKey> comparer;

	private KeyList keyList;

	private ValueList valueList;

	[NonSerialized]
	private object _syncRoot;

	private const int DefaultCapacity = 4;

	private const int MaxArrayLength = 2146435071;

	public int Capacity
	{
		set
		{
		}
	}

	public int Count => 0;

	public IList<TKey> Keys => null;

	ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

	public IList<TValue> Values => null;

	ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

	object ICollection.SyncRoot => null;

	public TValue this[TKey key]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	object IDictionary.this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SortedList()
	{
	}

	public SortedList(int capacity)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	private KeyList GetKeyListHelper()
	{
		return null;
	}

	private ValueList GetValueListHelper()
	{
		return null;
	}

	public void Clear()
	{
	}

	bool IDictionary.Contains(object key)
	{
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool ContainsValue(TValue value)
	{
		return false;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	private TValue GetByIndex(int index)
	{
		return default;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private TKey GetKey(int index)
	{
		return default;
	}

	public int IndexOfKey(TKey key)
	{
		return 0;
	}

	public int IndexOfValue(TValue value)
	{
		return 0;
	}

	private void Insert(int index, TKey key, TValue value)
	{
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default;
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	private static bool IsCompatibleKey(object key)
	{
		return false;
	}
}
