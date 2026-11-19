using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Sequence : Asn1Object, IEnumerable<Asn1Encodable>, IEnumerable
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

	private class Asn1SequenceParserImpl : Asn1SequenceParser, IAsn1Convertible
	{
		private readonly Asn1Sequence m_outer;

		private int m_index;

		public Asn1SequenceParserImpl(Asn1Sequence outer)
		{
		}

		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		public Asn1Object ToAsn1Object()
		{
			return null;
		}
	}

	internal readonly Asn1Encodable[] m_elements;

	public virtual Asn1SequenceParser Parser => null;

	public virtual Asn1Encodable this[int index] => null;

	public virtual int Count => 0;

	public static Asn1Sequence GetInstance(object obj)
	{
		return null;
	}

	public static Asn1Sequence GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal static Asn1Encodable[] ConcatenateElements(Asn1Sequence[] sequences)
	{
		return null;
	}

	protected internal Asn1Sequence()
	{
	}

	protected internal Asn1Sequence(Asn1Encodable element)
	{
	}

	protected internal Asn1Sequence(Asn1Encodable element1, Asn1Encodable element2)
	{
	}

	protected internal Asn1Sequence(params Asn1Encodable[] elements)
	{
	}

	internal Asn1Sequence(Asn1Encodable[] elements, bool clone)
	{
	}

	protected internal Asn1Sequence(Asn1EncodableVector elementVector)
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

	internal DerBitString[] GetConstructedBitStrings()
	{
		return null;
	}

	internal Asn1OctetString[] GetConstructedOctetStrings()
	{
		return null;
	}

	internal abstract DerBitString ToAsn1BitString();

	internal abstract DerExternal ToAsn1External();

	internal abstract Asn1OctetString ToAsn1OctetString();

	internal abstract Asn1Set ToAsn1Set();
}
