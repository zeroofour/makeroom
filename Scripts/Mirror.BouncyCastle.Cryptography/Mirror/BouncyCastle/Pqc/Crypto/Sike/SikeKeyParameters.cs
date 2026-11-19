using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public abstract class SikeKeyParameters : AsymmetricKeyParameter
{
	private readonly SikeParameters m_parameters;

	public SikeParameters Parameters => null;

	internal SikeKeyParameters(bool isPrivate, SikeParameters parameters)
		: base(privateKey: false)
	{
	}
}
