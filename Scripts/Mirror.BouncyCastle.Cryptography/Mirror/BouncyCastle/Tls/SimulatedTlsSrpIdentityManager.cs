using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class SimulatedTlsSrpIdentityManager : TlsSrpIdentityManager
{
	private static readonly byte[] PrefixPassword;

	private static readonly byte[] PrefixSalt;

	protected readonly Srp6Group m_group;

	protected readonly TlsSrp6VerifierGenerator m_verifierGenerator;

	protected readonly TlsMac m_mac;

	public static SimulatedTlsSrpIdentityManager GetRfc5054Default(TlsCrypto crypto, Srp6Group group, byte[] seedKey)
	{
		return null;
	}

	public SimulatedTlsSrpIdentityManager(Srp6Group group, TlsSrp6VerifierGenerator verifierGenerator, TlsMac mac)
	{
	}

	public virtual TlsSrpLoginParameters GetLoginParameters(byte[] identity)
	{
		return null;
	}
}
