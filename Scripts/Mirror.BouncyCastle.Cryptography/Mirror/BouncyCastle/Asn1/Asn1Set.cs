using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Set : Asn1Object, IEnumerable<Asn1Encodable>, IEnumerable
{
	internal class Meta : Asn1UniversalType
	{
		internal static readonly Asn1UniversalType Instance;

		private Meta()
			: base(null, 0)
		{
		}

		internal override Asn1Object FromImplicitConstructed(Asn1Sequence sequence)
		{
			return null;
		}
	}

	private class Asn1SetParserImpl : Asn1SetParser, IAsn1Convertible
	{
		private readonly Asn1Set m_outer;

		private int m_index;

		public Asn1SetParserImpl(Asn1Set outer)
		{
		}

		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		public virtual Asn1Object ToAsn1Object()
		{
			return null;
		}
	}

	internal readonly Asn1Encodable[] m_elements;

	internal DerEncoding[] m_sortedDerEncodings;

	public virtual Asn1Encodable this[int index] => null;

	public virtual int Count => 0;

	public Asn1SetParser Parser => null;

	public static Asn1Set GetInstance(object obj)
	{
		return null;
	}

	public static Asn1Set GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	protected internal Asn1Set()
	{
	}

	protected internal Asn1Set(Asn1Encodable element)
	{
	}

	protected internal Asn1Set(Asn1Encodable[] elements, bool doSort)
	{
	}

	protected internal Asn1Set(Asn1EncodableVector elementVector, bool doSort)
	{
	}

	protected internal Asn1Set(bool isSorted, Asn1Encodable[] elements)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public virtual IEnumerator<Asn1Encodable> GetEnumerator()
	{
		return null;
	}

	public virtual T[] MapElements<T>(Func<Asn1Encodable, T> func)
	{
		return null;
	}

	public virtual Asn1Encodable[] ToArray()
	{
		return null;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private static DerEncoding[] SortElements(Asn1Encodable[] elements)
	{
		return null;
	}
}
