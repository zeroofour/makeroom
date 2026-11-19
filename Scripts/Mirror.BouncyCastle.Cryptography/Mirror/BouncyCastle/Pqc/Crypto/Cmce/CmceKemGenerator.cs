using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Cmce;

public sealed class CmceKemGenerator : IEncapsulatedSecretGenerator
{
	private readonly SecureRandom sr;

	public CmceKemGenerator(SecureRandom random)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}

	private ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey, int sessionKeySizeInBits)
	{
		return null;
	}
}
