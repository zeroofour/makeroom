using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public sealed class DilithiumParameters : ICipherParameters
{
	public static DilithiumParameters Dilithium2;

	[Obsolete("Parameter set to be removed")]
	public static DilithiumParameters Dilithium2Aes;

	public static DilithiumParameters Dilithium3;

	[Obsolete("Parameter set to be removed")]
	public static DilithiumParameters Dilithium3Aes;

	public static DilithiumParameters Dilithium5;

	[Obsolete("Parameter set to be removed")]
	public static DilithiumParameters Dilithium5Aes;

	private int k;

	private bool usingAes;

	private DilithiumParameters(int param, bool usingAes)
	{
	}

	internal DilithiumEngine GetEngine(SecureRandom Random)
	{
		return null;
	}
}
