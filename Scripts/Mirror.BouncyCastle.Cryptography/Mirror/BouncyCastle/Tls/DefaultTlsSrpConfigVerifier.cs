using System.Collections.Generic;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DefaultTlsSrpConfigVerifier : TlsSrpConfigVerifier
{
	private static readonly List<Srp6Group> DefaultGroups;

	protected readonly IList<Srp6Group> m_groups;

	static DefaultTlsSrpConfigVerifier()
	{
	}

	public DefaultTlsSrpConfigVerifier()
	{
	}

	public DefaultTlsSrpConfigVerifier(IList<Srp6Group> groups)
	{
	}

	public virtual bool Accept(TlsSrpConfig srpConfig)
	{
		return false;
	}

	protected virtual bool AreGroupsEqual(TlsSrpConfig a, Srp6Group b)
	{
		return false;
	}

	protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
	{
		return false;
	}
}
