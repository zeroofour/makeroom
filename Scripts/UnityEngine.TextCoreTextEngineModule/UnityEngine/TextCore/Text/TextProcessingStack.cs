using System.Diagnostics;

namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T>
{
	public T[] itemStack = null;

	public int index = 0;

	private T m_DefaultItem = default;

	private int m_Capacity = 0;

	private int m_RolloverSize = 0;

	private int m_Count = 0;

	public TextProcessingStack(T[] stack)
	{
	}

	public TextProcessingStack(int capacity)
	{
	}

	public void Clear()
	{
	}

	public void SetDefault(T item)
	{
	}

	public void Add(T item)
	{
	}

	public T Remove()
	{
		return default;
	}

	public void Push(T item)
	{
	}

	public T Pop()
	{
		return default;
	}

	public T Peek()
	{
		return default;
	}

	public T CurrentItem()
	{
		return default;
	}
}
