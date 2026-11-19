using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsStreamVerifier : TlsStreamVerifier
{
	private readonly SignerSink m_output;

	private readonly byte[] m_signature;

	public Stream Stream => null;

	internal BcTlsStreamVerifier(ISigner verifier, byte[] signature)
	{
	}

	public bool IsVerified()
	{
		return false;
	}
}
