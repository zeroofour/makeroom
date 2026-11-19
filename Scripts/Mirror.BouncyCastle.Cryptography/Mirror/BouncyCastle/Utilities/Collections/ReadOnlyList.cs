using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal abstract class ReadOnlyList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public T this[int index]
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

	public void Insert(int index, T item)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public abstract bool Contains(T item);

	public abstract void CopyTo(T[] array, int arrayIndex);

	public abstract IEnumerator<T> GetEnumerator();

	public abstract int IndexOf(T item);

	protected abstract T Lookup(int index);
}
