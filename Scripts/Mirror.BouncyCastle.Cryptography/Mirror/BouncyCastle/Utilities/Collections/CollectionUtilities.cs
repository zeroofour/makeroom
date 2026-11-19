using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.Collections;

public abstract class CollectionUtilities
{
	public static void CollectMatches<T>(ICollection<T> matches, ISelector<T> selector, IEnumerable<IStore<T>> stores)
	{
	}

	public static IStore<T> CreateStore<T>(IEnumerable<T> contents)
	{
		return null;
	}

	public static T GetFirstOrNull<T>(IEnumerable<T> e) where T : class
	{
		return null;
	}

	public static T GetValueOrKey<T>(IDictionary<T, T> d, T k)
	{
		return default;
	}

	public static V GetValueOrNull<K, V>(IDictionary<K, V> d, K k) where V : class
	{
		return null;
	}

	public static IEnumerable<T> Proxy<T>(IEnumerable<T> e)
	{
		return null;
	}

	public static ICollection<T> ReadOnly<T>(ICollection<T> c)
	{
		return null;
	}

	public static IDictionary<K, V> ReadOnly<K, V>(IDictionary<K, V> d)
	{
		return null;
	}

	public static IList<T> ReadOnly<T>(IList<T> l)
	{
		return null;
	}

	public static ISet<T> ReadOnly<T>(ISet<T> s)
	{
		return null;
	}

	public static bool Remove<K, V>(IDictionary<K, V> d, K k, out V v)
	{
		v = default;
		return false;
	}

	public static T RequireNext<T>(IEnumerator<T> e)
	{
		return default;
	}

	public static string ToString<T>(IEnumerable<T> c)
	{
		return null;
	}
}
