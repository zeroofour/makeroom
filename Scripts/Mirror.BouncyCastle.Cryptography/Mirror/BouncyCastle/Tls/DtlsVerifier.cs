using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DtlsVerifier
{
	private readonly TlsCrypto m_crypto;

	private readonly byte[] m_macKey;

	public DtlsVerifier(TlsCrypto crypto)
	{
	}

	public virtual DtlsRequest VerifyRequest(byte[] clientID, byte[] data, int dataOff, int dataLen, DatagramSender sender)
	{
		return null;
	}
}
