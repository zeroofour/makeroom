using System;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public sealed class SikePublicKeyParameters : SikeKeyParameters
{
	public readonly byte[] publicKey;

	public SikePublicKeyParameters(SikeParameters param, byte[] publicKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetPublicKey()
	{
		return null;
	}
}
