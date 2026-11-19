using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Serializable]
	internal sealed class TreeSubSet : SortedSet<T>, ISerializable, IDeserializationCallback
	{
		private SortedSet<T> _underlying;

		private T _min;

		private T _max;

		private bool _lBoundActive;

		private bool _uBoundActive;

		internal override T MinInternal => default;

		internal override T MaxInternal => default;

		public TreeSubSet(SortedSet<T> Underlying, T Min, T Max, bool lowerBoundActive, bool upperBoundActive)
		{
		}

		internal override bool AddIfNotPresent(T item)
		{
			return false;
		}

		public override bool Contains(T item)
		{
			return false;
		}

		internal override bool DoRemove(T item)
		{
			return false;
		}

		public override void Clear()
		{
		}

		internal override bool IsWithinRange(T item)
		{
			return false;
		}

		internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			return false;
		}

		internal override bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
		{
			return false;
		}

		internal override Node FindNode(T item)
		{
			return null;
		}

		internal override int InternalIndexOf(T item)
		{
			return 0;
		}

		internal override void VersionCheck()
		{
		}

		private void VersionCheckImpl()
		{
		}

		public override SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		protected override void OnDeserialization(object sender)
		{
		}
	}

	[Serializable]
	internal sealed class Node
	{
		public T Item { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }

		public NodeColor Color { get; set; }

		public bool IsBlack => false;

		public bool IsRed => false;

		public bool Is2Node => false;

		public bool Is4Node => false;

		public Node(T item, NodeColor color)
		{
		}

		public static bool IsNonNullRed(Node node)
		{
			return false;
		}

		public static bool IsNullOrBlack(Node node)
		{
			return false;
		}

		public void ColorBlack()
		{
		}

		public void ColorRed()
		{
		}

		public TreeRotation GetRotation(Node current, Node sibling)
		{
			return TreeRotation.Left;
		}

		public Node GetSibling(Node node)
		{
			return null;
		}

		public void Split4Node()
		{
		}

		public Node Rotate(TreeRotation rotation)
		{
			return null;
		}

		public Node RotateLeft()
		{
			return null;
		}

		public Node RotateLeftRight()
		{
			return null;
		}

		public Node RotateRight()
		{
			return null;
		}

		public Node RotateRightLeft()
		{
			return null;
		}

		public void Merge2Nodes()
		{
		}

		public void ReplaceChild(Node child, Node newChild)
		{
		}
	}

	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private static readonly Node s_dummyNode;

		private SortedSet<T> _tree = null;

		private int _version = 0;

		private Stack<Node> _stack = null;

		private Node _current = null;

		private bool _reverse = false;

		public T Current => default;

		object IEnumerator.Current => null;

		internal Enumerator(SortedSet<T> set)
		{
		}

		internal Enumerator(SortedSet<T> set, bool reverse)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		private void Initialize()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Dispose()
		{
		}

		internal void Reset()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	internal struct ElementCount
	{
		internal int UniqueCount;

		internal int UnfoundCount;
	}

	private Node root;

	private IComparer<T> comparer;

	private int count;

	private int version;

	[NonSerialized]
	private object _syncRoot;

	private SerializationInfo siInfo;

	public int Count => 0;

	public IComparer<T> Comparer => null;

	bool ICollection<T>.IsReadOnly => false;

	object ICollection.SyncRoot => null;

	public T Min => default;

	internal virtual T MinInternal => default;

	public T Max => default;

	internal virtual T MaxInternal => default;

	public SortedSet()
	{
	}

	public SortedSet(IComparer<T> comparer)
	{
	}

	protected SortedSet(SerializationInfo info, StreamingContext context)
	{
	}

	private bool ContainsAllElements(IEnumerable<T> collection)
	{
		return false;
	}

	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
	{
		return false;
	}

	internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
	{
		return false;
	}

	internal virtual void VersionCheck()
	{
	}

	internal virtual bool IsWithinRange(T item)
	{
		return false;
	}

	public bool Add(T item)
	{
		return false;
	}

	void ICollection<T>.Add(T item)
	{
	}

	internal virtual bool AddIfNotPresent(T item)
	{
		return false;
	}

	public bool Remove(T item)
	{
		return false;
	}

	internal virtual bool DoRemove(T item)
	{
		return false;
	}

	public virtual void Clear()
	{
	}

	public virtual bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int index)
	{
	}

	public void CopyTo(T[] array, int index, int count)
	{
	}

	void ICollection.CopyTo(Array array, int index)
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

	private void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent)
	{
	}

	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild)
	{
	}

	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor)
	{
	}

	internal virtual Node FindNode(T item)
	{
		return null;
	}

	internal virtual int InternalIndexOf(T item)
	{
		return 0;
	}

	internal Node FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive)
	{
		return null;
	}

	private bool HasEqualComparer(SortedSet<T> other)
	{
		return false;
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	private bool IsSubsetOfSortedSetWithSameComparer(SortedSet<T> asSorted)
	{
		return false;
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		return false;
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		return false;
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		return false;
	}

	private ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
	{
		return default;
	}

	public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
	{
		return null;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	protected virtual void OnDeserialization(object sender)
	{
	}

	private static int Log2(int value)
	{
		return 0;
	}
}
