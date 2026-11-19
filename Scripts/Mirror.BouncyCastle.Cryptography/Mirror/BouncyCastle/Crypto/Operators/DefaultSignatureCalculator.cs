using System.IO;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class DefaultSignatureCalculator : IStreamCalculator<IBlockResult>
{
	private readonly SignerSink m_signerSink;

	public Stream Stream => null;

	public DefaultSignatureCalculator(ISigner signer)
	{
	}

	public IBlockResult GetResult()
	{
		return null;
	}
}
