namespace System.Collections.Generic;

public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
	new bool Add(T item);

	bool IsSubsetOf(IEnumerable<T> other);

	bool IsSupersetOf(IEnumerable<T> other);

	bool IsProperSupersetOf(IEnumerable<T> other);

	bool IsProperSubsetOf(IEnumerable<T> other);

	bool Overlaps(IEnumerable<T> other);

	bool SetEquals(IEnumerable<T> other);
}
