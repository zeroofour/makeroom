using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public sealed class SaberKemGenerator : IEncapsulatedSecretGenerator
{
	private SecureRandom sr;

	public SaberKemGenerator(SecureRandom random)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}
}
