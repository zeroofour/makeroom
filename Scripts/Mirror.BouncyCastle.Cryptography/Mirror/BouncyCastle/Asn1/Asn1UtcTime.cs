using System;
using System.Globalization;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1UtcTime : Asn1Object
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

	private readonly DateTime m_dateTime;

	private readonly bool m_dateTimeLocked;

	private readonly int m_twoDigitYearMax;

	public string TimeString => null;

	public int TwoDigitYearMax => 0;

	public static Asn1UtcTime GetInstance(object obj)
	{
		return null;
	}

	public static Asn1UtcTime GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public Asn1UtcTime(string timeString)
	{
	}

	[Obsolete("Use `Asn1UtcTime(DateTime, int)' instead")]
	public Asn1UtcTime(DateTime dateTime)
	{
	}

	public Asn1UtcTime(DateTime dateTime, int twoDigitYearMax)
	{
	}

	internal Asn1UtcTime(byte[] contents)
	{
	}

	public DateTime ToDateTime()
	{
		return default;
	}

	public DateTime ToDateTime(int twoDigitYearMax)
	{
		return default;
	}

	public DateTime ToDateTime(Calendar calendar)
	{
		return default;
	}

	[Obsolete("Use 'ToDateTime(2049)' instead")]
	public DateTime ToAdjustedDateTime()
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

	public override string ToString()
	{
		return null;
	}

	internal static Asn1UtcTime CreatePrimitive(byte[] contents)
	{
		return null;
	}

	private static DateTime FromString(string s, out int twoDigitYearMax)
	{
		twoDigitYearMax = default;
		return default;
	}

	private static bool InRange(DateTime dateTime, int twoDigitYearMax)
	{
		return false;
	}

	private static string ToStringCanonical(DateTime dateTime, out int twoDigitYearMax)
	{
		twoDigitYearMax = default;
		return null;
	}

	private static string ToStringCanonical(DateTime dateTime)
	{
		return null;
	}

	private static void Validate(DateTime dateTime, int twoDigitYearMax)
	{
	}
}
