using System.IO;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Crypto.Operators;

public sealed class DefaultMacCalculator : IStreamCalculator<IBlockResult>
{
	private readonly MacSink m_macSink;

	public Stream Stream => null;

	public DefaultMacCalculator(IMac mac)
	{
	}

	public IBlockResult GetResult()
	{
		return null;
	}
}
