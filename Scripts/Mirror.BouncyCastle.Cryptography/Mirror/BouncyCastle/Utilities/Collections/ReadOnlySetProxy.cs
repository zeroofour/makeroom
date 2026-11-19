using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal class ReadOnlySetProxy<T> : ReadOnlySet<T>
{
	private readonly ISet<T> m_target;

	public override int Count => 0;

	internal ReadOnlySetProxy(ISet<T> target)
	{
	}

	public override bool Contains(T item)
	{
		return false;
	}

	public override void CopyTo(T[] array, int arrayIndex)
	{
	}

	public override IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	public override bool IsProperSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	public override bool IsProperSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public override bool IsSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	public override bool IsSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public override bool Overlaps(IEnumerable<T> other)
	{
		return false;
	}
}
