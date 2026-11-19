using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pkcs;

public class AsymmetricKeyEntry : Pkcs12Entry
{
	private readonly AsymmetricKeyParameter key;

	public AsymmetricKeyParameter Key => null;

	public AsymmetricKeyEntry(AsymmetricKeyParameter key)
		: base(null)
	{
	}

	public AsymmetricKeyEntry(AsymmetricKeyParameter key, IDictionary<DerObjectIdentifier, Asn1Encodable> attributes)
		: base(null)
	{
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
