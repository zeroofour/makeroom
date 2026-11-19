using System;
using System.Security.Cryptography;

namespace Mirror.BouncyCastle.Crypto.Prng;

public sealed class CryptoApiRandomGenerator : IRandomGenerator, IDisposable
{
	private readonly RandomNumberGenerator m_randomNumberGenerator;

	public CryptoApiRandomGenerator()
	{
	}

	public CryptoApiRandomGenerator(RandomNumberGenerator randomNumberGenerator)
	{
	}

	public void AddSeedMaterial(byte[] seed)
	{
	}

	public void AddSeedMaterial(long seed)
	{
	}

	public void NextBytes(byte[] bytes)
	{
	}

	public void NextBytes(byte[] bytes, int start, int len)
	{
	}

	public void Dispose()
	{
	}
}
