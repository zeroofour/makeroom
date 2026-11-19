using Mirror.BouncyCastle.Crypto.Agreement.Srp;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsSrp6Server : TlsSrp6Server
{
	private readonly Srp6Server m_srp6Server;

	internal BcTlsSrp6Server(Srp6Server srp6Server)
	{
	}

	public BigInteger GenerateServerCredentials()
	{
		return null;
	}

	public BigInteger CalculateSecret(BigInteger clientA)
	{
		return null;
	}
}
