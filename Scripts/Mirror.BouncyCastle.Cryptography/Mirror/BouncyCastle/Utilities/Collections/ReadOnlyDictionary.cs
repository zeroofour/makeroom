using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal abstract class ReadOnlyDictionary<K, V> : IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable
{
	public V this[K key]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool IsReadOnly => false;

	public abstract int Count { get; }

	public abstract ICollection<K> Keys { get; }

	public abstract ICollection<V> Values { get; }

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Add(K key, V value)
	{
	}

	public void Add(KeyValuePair<K, V> item)
	{
	}

	public void Clear()
	{
	}

	public bool Remove(K key)
	{
		return false;
	}

	public bool Remove(KeyValuePair<K, V> item)
	{
		return false;
	}

	public abstract bool Contains(KeyValuePair<K, V> item);

	public abstract bool ContainsKey(K key);

	public abstract void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex);

	public abstract IEnumerator<KeyValuePair<K, V>> GetEnumerator();

	public abstract bool TryGetValue(K key, out V value);

	protected abstract V Lookup(K key);
}
