using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public class FrodoKEMGenerator : IEncapsulatedSecretGenerator
{
	private readonly SecureRandom m_random;

	public FrodoKEMGenerator(SecureRandom random)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}
}
