namespace Mirror.BouncyCastle.Crypto.Operators;

public class DefaultVerifierResult : IVerifier
{
	private readonly ISigner m_signer;

	public DefaultVerifierResult(ISigner signer)
	{
	}

	public bool IsVerified(byte[] signature)
	{
		return false;
	}

	public bool IsVerified(byte[] sig, int sigOff, int sigLen)
	{
		return false;
	}
}
