using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Agreement.Srp;

public class Srp6VerifierGenerator
{
	protected BigInteger N;

	protected BigInteger g;

	protected IDigest digest;

	public virtual void Init(BigInteger N, BigInteger g, IDigest digest)
	{
	}

	public virtual void Init(Srp6GroupParameters group, IDigest digest)
	{
	}

	public virtual BigInteger GenerateVerifier(byte[] salt, byte[] identity, byte[] password)
	{
		return null;
	}
}
