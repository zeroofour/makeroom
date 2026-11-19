using System.IO;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public sealed class LegacyTls13Verifier : TlsVerifier
{
	private class TlsStreamVerifierImpl : TlsStreamVerifier
	{
		private readonly Tls13Verifier m_tls13Verifier;

		private readonly byte[] m_signature;

		public Stream Stream => null;

		internal TlsStreamVerifierImpl(Tls13Verifier tls13Verifier, byte[] signature)
		{
		}

		public bool IsVerified()
		{
			return false;
		}
	}

	private readonly int m_signatureScheme;

	private readonly Tls13Verifier m_tls13Verifier;

	public LegacyTls13Verifier(int signatureScheme, Tls13Verifier tls13Verifier)
	{
	}

	public TlsStreamVerifier GetStreamVerifier(DigitallySigned digitallySigned)
	{
		return null;
	}

	public bool VerifyRawSignature(DigitallySigned digitallySigned, byte[] hash)
	{
		return false;
	}
}
