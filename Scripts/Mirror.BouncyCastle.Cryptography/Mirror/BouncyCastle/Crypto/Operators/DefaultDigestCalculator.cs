using System.IO;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Crypto.Operators;

public sealed class DefaultDigestCalculator : IStreamCalculator<IBlockResult>
{
	private readonly DigestSink m_digestSink;

	public Stream Stream => null;

	public DefaultDigestCalculator(IDigest digest)
	{
	}

	public IBlockResult GetResult()
	{
		return null;
	}
}
