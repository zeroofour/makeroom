using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTls13Verifier : Tls13Verifier
{
	private readonly SignerSink m_output;

	public Stream Stream => null;

	internal BcTls13Verifier(ISigner verifier)
	{
	}

	public bool VerifySignature(byte[] signature)
	{
		return false;
	}
}
