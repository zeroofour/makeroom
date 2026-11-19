using System;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Cmp;

public class PkiStatusInfo : Asn1Encodable
{
	private readonly DerInteger m_status;

	private readonly PkiFreeText m_statusString;

	private readonly DerBitString m_failInfo;

	public BigInteger Status => null;

	public PkiFreeText StatusString => null;

	public DerBitString FailInfo => null;

	public static PkiStatusInfo GetInstance(object obj)
	{
		return null;
	}

	public static PkiStatusInfo GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	[Obsolete("Use 'GetInstance' instead")]
	public PkiStatusInfo(Asn1Sequence seq)
	{
	}

	public PkiStatusInfo(int status)
	{
	}

	public PkiStatusInfo(int status, PkiFreeText statusString)
	{
	}

	public PkiStatusInfo(int status, PkiFreeText statusString, PkiFailureInfo failInfo)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
