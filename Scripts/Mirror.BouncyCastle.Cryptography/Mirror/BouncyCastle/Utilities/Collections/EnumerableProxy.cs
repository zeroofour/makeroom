using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

internal sealed class EnumerableProxy<T> : IEnumerable<T>, IEnumerable
{
	private readonly IEnumerable<T> m_target;

	internal EnumerableProxy(IEnumerable<T> target)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}
}
