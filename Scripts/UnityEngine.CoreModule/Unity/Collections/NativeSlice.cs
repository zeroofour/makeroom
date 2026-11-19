using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections;

[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
[DebuggerTypeProxy(typeof(NativeSliceDebugView<>))]
[DebuggerDisplay("Length = {Length}")]
public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> where T : struct
{
	[ExcludeFromDocs]
	public struct Enumerator(ref NativeSlice<T> array) : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeSlice<T> m_Array = default;

		private int m_Index = 0;

		public T Current => default;

		object IEnumerator.Current => null;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	internal unsafe byte* m_Buffer = null;

	internal int m_Stride = 0;

	internal int m_Length = 0;

	public T this[int index]
	{
		get
		{
			return default;
		}
		[WriteAccessRequired]
		set
		{
		}
	}

	public int Stride => 0;

	public int Length => 0;

	public unsafe NativeSlice(NativeSlice<T> slice, int start, int length)
	{
	}

	public unsafe NativeSlice(NativeArray<T> array)
	{
	}

	public static implicit operator NativeSlice<T>(NativeArray<T> array)
	{
		return default;
	}

	public unsafe NativeSlice(NativeArray<T> array, int start, int length)
	{
	}

	[WriteAccessRequired]
	public void CopyFrom(NativeSlice<T> slice)
	{
	}

	[WriteAccessRequired]
	public void CopyFrom(T[] array)
	{
	}

	public Enumerator GetEnumerator()
	{
		return default;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool Equals(NativeSlice<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right)
	{
		return false;
	}
}
