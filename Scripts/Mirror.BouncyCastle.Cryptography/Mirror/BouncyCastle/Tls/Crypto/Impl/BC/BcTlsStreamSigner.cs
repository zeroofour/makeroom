using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsStreamSigner : TlsStreamSigner
{
	private readonly SignerSink m_output;

	public Stream Stream => null;

	internal BcTlsStreamSigner(ISigner signer)
	{
	}

	public byte[] GetSignature()
	{
		return null;
	}
}
