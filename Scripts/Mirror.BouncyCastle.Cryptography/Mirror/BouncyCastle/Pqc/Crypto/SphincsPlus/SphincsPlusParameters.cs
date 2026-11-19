using System;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

public sealed class SphincsPlusParameters
{
	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_128f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_128s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_192f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_192s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_256f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters sha2_256s;

	public static readonly SphincsPlusParameters sha2_128f_simple;

	public static readonly SphincsPlusParameters sha2_128s_simple;

	public static readonly SphincsPlusParameters sha2_192f_simple;

	public static readonly SphincsPlusParameters sha2_192s_simple;

	public static readonly SphincsPlusParameters sha2_256f_simple;

	public static readonly SphincsPlusParameters sha2_256s_simple;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_128f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_128s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_192f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_192s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_256f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters shake_256s;

	public static readonly SphincsPlusParameters shake_128f_simple;

	public static readonly SphincsPlusParameters shake_128s_simple;

	public static readonly SphincsPlusParameters shake_192f_simple;

	public static readonly SphincsPlusParameters shake_192s_simple;

	public static readonly SphincsPlusParameters shake_256f_simple;

	public static readonly SphincsPlusParameters shake_256s_simple;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_128f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_128s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_192f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_192s;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_256f;

	[Obsolete("Parameter set to be removed")]
	public static readonly SphincsPlusParameters haraka_256s;

	public static readonly SphincsPlusParameters haraka_128f_simple;

	public static readonly SphincsPlusParameters haraka_128s_simple;

	public static readonly SphincsPlusParameters haraka_192f_simple;

	public static readonly SphincsPlusParameters haraka_192s_simple;

	public static readonly SphincsPlusParameters haraka_256f_simple;

	public static readonly SphincsPlusParameters haraka_256s_simple;

	private static readonly Dictionary<int, SphincsPlusParameters> IdToParams;

	private readonly int m_id;

	private readonly string m_name;

	private readonly ISphincsPlusEngineProvider m_engineProvider;

	public int ID => 0;

	public string Name => null;

	internal int N => 0;

	static SphincsPlusParameters()
	{
	}

	private SphincsPlusParameters(int id, string name, ISphincsPlusEngineProvider engineProvider)
	{
	}

	internal SphincsPlusEngine GetEngine()
	{
		return null;
	}

	public static SphincsPlusParameters GetParams(int id)
	{
		return null;
	}

	[Obsolete("Use 'ID' property instead")]
	public static int GetID(SphincsPlusParameters parameters)
	{
		return 0;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
