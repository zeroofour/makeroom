using System.Collections.Generic;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public class DefaultTlsDHGroupVerifier : TlsDHGroupVerifier
{
	public static readonly int DefaultMinimumPrimeBits;

	private static readonly List<DHGroup> DefaultGroups;

	protected readonly IList<DHGroup> m_groups;

	protected readonly int m_minimumPrimeBits;

	public virtual int MinimumPrimeBits => 0;

	private static void AddDefaultGroup(DHGroup dhGroup)
	{
	}

	static DefaultTlsDHGroupVerifier()
	{
	}

	public DefaultTlsDHGroupVerifier()
	{
	}

	public DefaultTlsDHGroupVerifier(int minimumPrimeBits)
	{
	}

	public DefaultTlsDHGroupVerifier(IList<DHGroup> groups, int minimumPrimeBits)
	{
	}

	public virtual bool Accept(DHGroup dhGroup)
	{
		return false;
	}

	protected virtual bool AreGroupsEqual(DHGroup a, DHGroup b)
	{
		return false;
	}

	protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
	{
		return false;
	}

	protected virtual bool CheckGroup(DHGroup dhGroup)
	{
		return false;
	}

	protected virtual bool CheckMinimumPrimeBits(DHGroup dhGroup)
	{
		return false;
	}
}
