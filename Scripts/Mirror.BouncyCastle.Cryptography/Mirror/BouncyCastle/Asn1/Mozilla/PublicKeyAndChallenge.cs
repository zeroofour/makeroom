using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Mozilla;

public class PublicKeyAndChallenge : Asn1Encodable
{
	private readonly SubjectPublicKeyInfo m_spki;

	private readonly DerIA5String m_challenge;

	public DerIA5String Challenge => null;

	public SubjectPublicKeyInfo Spki => null;

	[Obsolete("Use 'Spki' instead")]
	public SubjectPublicKeyInfo SubjectPublicKeyInfo => null;

	public static PublicKeyAndChallenge GetInstance(object obj)
	{
		return null;
	}

	public static PublicKeyAndChallenge GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public PublicKeyAndChallenge(SubjectPublicKeyInfo spki, DerIA5String challenge)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public PublicKeyAndChallenge(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
