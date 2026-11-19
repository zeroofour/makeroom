using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class TlsSrpLoginParameters
{
	protected byte[] m_identity;

	protected TlsSrpConfig m_srpConfig;

	protected BigInteger m_verifier;

	protected byte[] m_salt;

	public virtual TlsSrpConfig Config => null;

	public virtual byte[] Identity => null;

	public virtual byte[] Salt => null;

	public virtual BigInteger Verifier => null;

	public TlsSrpLoginParameters(byte[] identity, TlsSrpConfig srpConfig, BigInteger verifier, byte[] salt)
	{
	}
}
