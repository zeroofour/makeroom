using System.Threading;
using System.Threading.Tasks;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Crypto.IO;

public sealed class SignerSink : BaseOutputStream
{
	private readonly ISigner m_signer;

	public ISigner Signer => null;

	public SignerSink(ISigner signer)
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
