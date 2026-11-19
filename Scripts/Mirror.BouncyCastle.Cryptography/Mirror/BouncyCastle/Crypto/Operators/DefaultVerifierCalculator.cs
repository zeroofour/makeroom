using System.IO;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class DefaultVerifierCalculator : IStreamCalculator<IVerifier>
{
	private readonly SignerSink m_signerSink;

	public Stream Stream => null;

	public DefaultVerifierCalculator(ISigner signer)
	{
	}

	public IVerifier GetResult()
	{
		return null;
	}
}
