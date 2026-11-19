using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal abstract class ReadOnlySet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public bool IsReadOnly => false;

	public abstract int Count { get; }

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	void ICollection<T>.Add(T item)
	{
	}

	public bool Add(T item)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void ExceptWith(IEnumerable<T> other)
	{
	}

	public void IntersectWith(IEnumerable<T> other)
	{
	}

	public bool Remove(T item)
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

	public abstract bool Contains(T item);

	public abstract void CopyTo(T[] array, int arrayIndex);

	public abstract IEnumerator<T> GetEnumerator();

	public abstract bool IsProperSubsetOf(IEnumerable<T> other);

	public abstract bool IsProperSupersetOf(IEnumerable<T> other);

	public abstract bool IsSubsetOf(IEnumerable<T> other);

	public abstract bool IsSupersetOf(IEnumerable<T> other);

	public abstract bool Overlaps(IEnumerable<T> other);
}
