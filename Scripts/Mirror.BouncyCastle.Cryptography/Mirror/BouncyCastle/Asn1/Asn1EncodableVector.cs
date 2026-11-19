using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1EncodableVector : IEnumerable<Asn1Encodable>, IEnumerable
{
	internal static readonly Asn1Encodable[] EmptyElements;

	private const int DefaultCapacity = 10;

	private Asn1Encodable[] elements;

	private int elementCount;

	private bool copyOnWrite;

	public Asn1Encodable this[int index] => null;

	public int Count => 0;

	public static Asn1EncodableVector FromEnumerable(IEnumerable<Asn1Encodable> e)
	{
		return null;
	}

	public Asn1EncodableVector()
	{
	}

	public Asn1EncodableVector(int initialCapacity)
	{
	}

	public Asn1EncodableVector(Asn1Encodable element)
	{
	}

	public Asn1EncodableVector(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public Asn1EncodableVector(params Asn1Encodable[] v)
	{
	}

	public void Add(Asn1Encodable element)
	{
	}

	public void Add(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public void Add(params Asn1Encodable[] objs)
	{
	}

	public void AddOptional(Asn1Encodable element)
	{
	}

	public void AddOptional(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	public void AddOptional(params Asn1Encodable[] elements)
	{
	}

	public void AddOptionalTagged(bool isExplicit, int tagNo, Asn1Encodable obj)
	{
	}

	public void AddOptionalTagged(bool isExplicit, int tagClass, int tagNo, Asn1Encodable obj)
	{
	}

	public void AddAll(Asn1EncodableVector other)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IEnumerator<Asn1Encodable> GetEnumerator()
	{
		return null;
	}

	internal Asn1Encodable[] CopyElements()
	{
		return null;
	}

	internal Asn1Encodable[] TakeElements()
	{
		return null;
	}

	private void Reallocate(int minCapacity)
	{
	}

	internal static Asn1Encodable[] CloneElements(Asn1Encodable[] elements)
	{
		return null;
	}
}
