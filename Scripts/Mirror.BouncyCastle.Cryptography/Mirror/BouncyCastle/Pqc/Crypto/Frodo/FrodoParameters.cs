using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Digests;

namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public sealed class FrodoParameters : ICipherParameters
{
	private static readonly short[] cdf_table640;

	private static readonly short[] cdf_table976;

	private static readonly short[] cdf_table1344;

	public static readonly FrodoParameters frodokem640aes;

	public static readonly FrodoParameters frodokem640shake;

	public static readonly FrodoParameters frodokem976aes;

	public static readonly FrodoParameters frodokem976shake;

	public static readonly FrodoParameters frodokem1344aes;

	public static readonly FrodoParameters frodokem1344shake;

	[Obsolete("Use 'frodokem640aes' instead")]
	public static FrodoParameters frodokem19888r3;

	[Obsolete("Use 'frodokem640shake' instead")]
	public static FrodoParameters frodokem19888shaker3;

	[Obsolete("Use 'frodokem976aes' instead")]
	public static FrodoParameters frodokem31296r3;

	[Obsolete("Use 'frodokem976shake' instead")]
	public static FrodoParameters frodokem31296shaker3;

	[Obsolete("Use 'frodokem1344aes' instead")]
	public static FrodoParameters frodokem43088r3;

	[Obsolete("Use 'frodokem1344shake' instead")]
	public static FrodoParameters frodokem43088shaker3;

	private readonly string name;

	private readonly int n;

	private readonly int d;

	private readonly int b;

	private readonly short[] cdf_table;

	private readonly ShakeDigest digest;

	private readonly FrodoMatrixGenerator mGen;

	private readonly int defaultKeySize;

	private readonly FrodoEngine engine;

	public string Name => null;

	public int DefaultKeySize => 0;

	[Obsolete("Will be removed")]
	public FrodoEngine Engine => null;

	[Obsolete("Will be removed")]
	public int N => 0;

	[Obsolete("Will be removed")]
	public int D => 0;

	[Obsolete("Will be removed")]
	public int B => 0;

	[Obsolete("Will be removed")]
	public short[] CdfTable => null;

	[Obsolete("Will be removed")]
	public IDigest Digest => null;

	[Obsolete("Will be removed")]
	public FrodoMatrixGenerator MGen => null;

	private FrodoParameters(string name, int n, int d, int b, short[] cdf_table, ShakeDigest digest, FrodoMatrixGenerator mGen)
	{
	}
}
