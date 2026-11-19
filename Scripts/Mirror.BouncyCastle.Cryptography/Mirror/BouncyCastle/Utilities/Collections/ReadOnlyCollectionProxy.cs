using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal class ReadOnlyCollectionProxy<T> : ReadOnlyCollection<T>
{
	private readonly ICollection<T> m_target;

	public override int Count => 0;

	internal ReadOnlyCollectionProxy(ICollection<T> target)
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
}
