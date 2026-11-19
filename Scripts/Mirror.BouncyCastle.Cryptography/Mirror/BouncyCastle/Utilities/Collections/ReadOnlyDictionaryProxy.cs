using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal class ReadOnlyDictionaryProxy<K, V> : ReadOnlyDictionary<K, V>
{
	private readonly IDictionary<K, V> m_target;

	public override int Count => 0;

	public override ICollection<K> Keys => null;

	public override ICollection<V> Values => null;

	internal ReadOnlyDictionaryProxy(IDictionary<K, V> target)
	{
	}

	public override bool Contains(KeyValuePair<K, V> item)
	{
		return false;
	}

	public override bool ContainsKey(K key)
	{
		return false;
	}

	public override void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
	{
	}

	public override IEnumerator<KeyValuePair<K, V>> GetEnumerator()
	{
		return null;
	}

	public override bool TryGetValue(K key, out V value)
	{
		value = default;
		return false;
	}

	protected override V Lookup(K key)
	{
		return default;
	}
}
