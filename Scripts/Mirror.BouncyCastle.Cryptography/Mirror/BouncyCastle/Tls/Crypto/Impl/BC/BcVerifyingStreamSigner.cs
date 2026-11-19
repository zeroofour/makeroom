using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcVerifyingStreamSigner : TlsStreamSigner
{
	private readonly ISigner m_signer;

	private readonly ISigner m_verifier;

	private readonly TeeOutputStream m_output;

	public Stream Stream => null;

	internal BcVerifyingStreamSigner(ISigner signer, ISigner verifier)
	{
	}

	public byte[] GetSignature()
	{
		return null;
	}
}
