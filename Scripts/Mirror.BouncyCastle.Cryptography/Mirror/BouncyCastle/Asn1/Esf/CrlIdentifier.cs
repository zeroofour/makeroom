using System;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class CrlIdentifier : Asn1Encodable
{
	private readonly X509Name m_crlIssuer;

	private readonly Asn1UtcTime m_crlIssuedTime;

	private readonly DerInteger m_crlNumber;

	public X509Name CrlIssuer => null;

	public DateTime CrlIssuedTime => default;

	public BigInteger CrlNumber => null;

	public static CrlIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static CrlIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private CrlIdentifier(Asn1Sequence seq)
	{
	}

	public CrlIdentifier(X509Name crlIssuer, DateTime crlIssuedTime)
	{
	}

	public CrlIdentifier(X509Name crlIssuer, DateTime crlIssuedTime, BigInteger crlNumber)
	{
	}

	public CrlIdentifier(X509Name crlIssuer, Asn1UtcTime crlIssuedTime)
	{
	}

	public CrlIdentifier(X509Name crlIssuer, Asn1UtcTime crlIssuedTime, BigInteger crlNumber)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
