using System;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1GeneralizedTime : Asn1Object
{
	internal class Meta : Asn1UniversalType
	{
		internal static readonly Asn1UniversalType Instance;

		private Meta()
			: base(null, 0)
		{
		}

		internal override Asn1Object FromImplicitPrimitive(DerOctetString octetString)
		{
			return null;
		}
	}

	private readonly string m_timeString;

	private readonly bool m_timeStringCanonical;

	private readonly DateTime m_dateTime;

	public string TimeString => null;

	public static Asn1GeneralizedTime GetInstance(object obj)
	{
		return null;
	}

	public static Asn1GeneralizedTime GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public Asn1GeneralizedTime(string timeString)
	{
	}

	public Asn1GeneralizedTime(DateTime dateTime)
	{
	}

	internal Asn1GeneralizedTime(byte[] contents)
	{
	}

	public DateTime ToDateTime()
	{
		return default;
	}

	internal byte[] GetContents(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncoding(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
	{
		return null;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	internal static Asn1GeneralizedTime CreatePrimitive(byte[] contents)
	{
		return null;
	}

	private static DateTime FromString(string s)
	{
		return default;
	}

	private static int IndexOfSign(string s, int startIndex)
	{
		return 0;
	}

	private static DateTime ParseLocal(string s, string format)
	{
		return default;
	}

	private static DateTime ParseTimeZone(string s, string format)
	{
		return default;
	}

	private static DateTime ParseUtc(string s, string format)
	{
		return default;
	}

	private static string ToStringCanonical(DateTime dateTime)
	{
		return null;
	}
}
