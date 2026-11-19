using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private LinkedList<T> _list = null;

		private LinkedListNode<T> _node = null;

		private int _version = 0;

		private T _current = default;

		private int _index = 0;

		public T Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(LinkedList<T> list)
		{
		}

		private Enumerator(SerializationInfo info, StreamingContext context)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		public void Dispose()
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}
	}

	internal LinkedListNode<T> head;

	internal int count;

	internal int version;

	private object _syncRoot;

	private SerializationInfo _siInfo;

	public int Count => 0;

	public LinkedListNode<T> First => null;

	bool ICollection<T>.IsReadOnly => false;

	object ICollection.SyncRoot => null;

	public LinkedList()
	{
	}

	protected LinkedList(SerializationInfo info, StreamingContext context)
	{
	}

	void ICollection<T>.Add(T value)
	{
	}

	public LinkedListNode<T> AddLast(T value)
	{
		return null;
	}

	public void Clear()
	{
	}

	public bool Contains(T value)
	{
		return false;
	}

	public void CopyTo(T[] array, int index)
	{
	}

	public LinkedListNode<T> Find(T value)
	{
		return null;
	}

	public Enumerator GetEnumerator()
	{
		return default;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	public bool Remove(T value)
	{
		return false;
	}

	public void RemoveFirst()
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual void OnDeserialization(object sender)
	{
	}

	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
	{
	}

	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
	{
	}

	internal void InternalRemoveNode(LinkedListNode<T> node)
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
