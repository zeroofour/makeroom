using System;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Ocsp;

public class RespID : IEquatable<RespID>
{
	private readonly ResponderID m_id;

	public RespID(ResponderID id)
	{
	}

	public RespID(X509Name name)
	{
	}

	public RespID(AsymmetricKeyParameter publicKey)
	{
	}

	public ResponderID ToAsn1Object()
	{
		return null;
	}

	public bool Equals(RespID other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
