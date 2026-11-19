using Mirror.BouncyCastle.Crypto.Agreement.Srp;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsSrp6Client : TlsSrp6Client
{
	private readonly Srp6Client m_srp6Client;

	internal BcTlsSrp6Client(Srp6Client srpClient)
	{
	}

	public BigInteger CalculateSecret(BigInteger serverB)
	{
		return null;
	}

	public BigInteger GenerateClientCredentials(byte[] srpSalt, byte[] identity, byte[] password)
	{
		return null;
	}
}
