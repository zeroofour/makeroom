using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberParameters : IKemParameters, ICipherParameters
{
	public static KyberParameters kyber512;

	public static KyberParameters kyber768;

	public static KyberParameters kyber1024;

	[Obsolete("Parameter set to be removed")]
	public static KyberParameters kyber512_aes;

	[Obsolete("Parameter set to be removed")]
	public static KyberParameters kyber768_aes;

	[Obsolete("Parameter set to be removed")]
	public static KyberParameters kyber1024_aes;

	private string m_name;

	private int m_sessionKeySize;

	private KyberEngine m_engine;

	public string Name => null;

	public int K => 0;

	public int SessionKeySize => 0;

	internal KyberEngine Engine => null;

	private KyberParameters(string name, int k, int sessionKeySize, bool usingAes)
	{
	}
}
