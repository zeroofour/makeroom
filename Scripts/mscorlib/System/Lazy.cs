using System.Diagnostics;
using System.Threading;

namespace System;

[Serializable]
[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView<>))]
public class Lazy<T>
{
	private LazyHelper _state;

	private Func<T> _factory;

	private T _value;

	public bool IsValueCreated => false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public T Value => default;

	private static T CreateViaDefaultConstructor()
	{
		return default;
	}

	public Lazy()
	{
	}

	public Lazy(Func<T> valueFactory)
	{
	}

	private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
	{
	}

	private void ViaConstructor()
	{
	}

	private void ViaFactory(LazyThreadSafetyMode mode)
	{
	}

	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
	{
	}

	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
	{
	}

	private void PublicationOnlyViaConstructor(LazyHelper initializer)
	{
	}

	private void PublicationOnlyViaFactory(LazyHelper initializer)
	{
	}

	private void PublicationOnlyWaitForOtherThreadToPublish()
	{
	}

	private T CreateValue()
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
