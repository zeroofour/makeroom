using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public sealed class NtruParameters : IKemParameters, ICipherParameters
{
	public static readonly NtruParameters NtruHps2048509;

	public static readonly NtruParameters NtruHps2048677;

	public static readonly NtruParameters NtruHps4096821;

	public static readonly NtruParameters NtruHrss701;

	internal readonly NtruParameterSet ParameterSet;

	private readonly string _name;

	public string Name => null;

	public int DefaultKeySize => 0;

	private NtruParameters(string name, NtruParameterSet parameterSet)
	{
	}
}
