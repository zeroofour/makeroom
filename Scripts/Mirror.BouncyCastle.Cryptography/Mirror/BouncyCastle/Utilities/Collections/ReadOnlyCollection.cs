using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal abstract class ReadOnlyCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
	public bool IsReadOnly => false;

	public abstract int Count { get; }

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Add(T item)
	{
	}

	public void Clear()
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public abstract bool Contains(T item);

	public abstract void CopyTo(T[] array, int arrayIndex);

	public abstract IEnumerator<T> GetEnumerator();
}
