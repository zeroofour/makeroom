using System;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public sealed class SikePrivateKeyParameters : SikeKeyParameters
{
	private readonly byte[] privateKey;

	public SikePrivateKeyParameters(SikeParameters param, byte[] privateKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetPrivateKey()
	{
		return null;
	}
}
