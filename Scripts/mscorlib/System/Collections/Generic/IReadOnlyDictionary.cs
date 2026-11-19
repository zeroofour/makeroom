using System.Reflection;

namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	IEnumerable<TKey> Keys { get; }

	IEnumerable<TValue> Values { get; }

	bool TryGetValue(TKey key, out TValue value);
}
