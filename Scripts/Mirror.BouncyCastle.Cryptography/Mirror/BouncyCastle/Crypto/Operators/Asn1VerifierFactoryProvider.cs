using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1VerifierFactoryProvider : IVerifierFactoryProvider
{
	private readonly AsymmetricKeyParameter publicKey;

	public IEnumerable<string> SignatureAlgNames => null;

	public Asn1VerifierFactoryProvider(AsymmetricKeyParameter publicKey)
	{
	}

	public IVerifierFactory CreateVerifierFactory(object algorithmDetails)
	{
		return null;
	}
}
