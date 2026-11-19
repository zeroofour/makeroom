using System;

namespace Mirror.BouncyCastle.Asn1.X509;

public class Time : Asn1Encodable, IAsn1Choice
{
	private readonly Asn1Object m_timeObject;

	public static Time GetInstance(object obj)
	{
		return null;
	}

	public static Time GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public Time(Asn1GeneralizedTime generalizedTime)
	{
	}

	public Time(Asn1UtcTime utcTime)
	{
	}

	public Time(DateTime date)
	{
	}

	public DateTime ToDateTime()
	{
		return default;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
