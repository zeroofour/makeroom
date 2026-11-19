using System.Threading;
using System.Threading.Tasks;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Crypto.IO;

public sealed class DigestSink : BaseOutputStream
{
	private readonly IDigest m_digest;

	public IDigest Digest => null;

	public DigestSink(IDigest digest)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void WriteByte(byte value)
	{
	}
}
