using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal class ReadOnlyListProxy<T> : ReadOnlyList<T>
{
	private readonly IList<T> m_target;

	public override int Count => 0;

	internal ReadOnlyListProxy(IList<T> target)
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

	public override int IndexOf(T item)
	{
		return 0;
	}

	protected override T Lookup(int index)
	{
		return default;
	}
}
