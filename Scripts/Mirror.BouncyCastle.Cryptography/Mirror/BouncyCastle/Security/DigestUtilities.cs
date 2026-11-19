using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class DigestUtilities
{
	private enum DigestAlgorithm
	{
		BLAKE2B_160 = 0,
		BLAKE2B_256 = 1,
		BLAKE2B_384 = 2,
		BLAKE2B_512 = 3,
		BLAKE2S_128 = 4,
		BLAKE2S_160 = 5,
		BLAKE2S_224 = 6,
		BLAKE2S_256 = 7,
		BLAKE3_256 = 8,
		DSTU7564_256 = 9,
		DSTU7564_384 = 10,
		DSTU7564_512 = 11,
		GOST3411 = 12,
		GOST3411_2012_256 = 13,
		GOST3411_2012_512 = 14,
		KECCAK_224 = 15,
		KECCAK_256 = 16,
		KECCAK_288 = 17,
		KECCAK_384 = 18,
		KECCAK_512 = 19,
		MD2 = 20,
		MD4 = 21,
		MD5 = 22,
		NONE = 23,
		RIPEMD128 = 24,
		RIPEMD160 = 25,
		RIPEMD256 = 26,
		RIPEMD320 = 27,
		SHA_1 = 28,
		SHA_224 = 29,
		SHA_256 = 30,
		SHA_384 = 31,
		SHA_512 = 32,
		SHA_512_224 = 33,
		SHA_512_256 = 34,
		SHA3_224 = 35,
		SHA3_256 = 36,
		SHA3_384 = 37,
		SHA3_512 = 38,
		SHAKE128_256 = 39,
		SHAKE256_512 = 40,
		SM3 = 41,
		TIGER = 42,
		WHIRLPOOL = 43
	}

	private static readonly Dictionary<string, string> AlgorithmMap;

	private static readonly Dictionary<DerObjectIdentifier, string> AlgorithmOidMap;

	private static readonly Dictionary<string, DerObjectIdentifier> Oids;

	static DigestUtilities()
	{
	}

	public static byte[] CalculateDigest(DerObjectIdentifier id, byte[] input)
	{
		return null;
	}

	public static byte[] CalculateDigest(string algorithm, byte[] input)
	{
		return null;
	}

	public static byte[] CalculateDigest(string algorithm, byte[] buf, int off, int len)
	{
		return null;
	}

	public static byte[] DoFinal(IDigest digest)
	{
		return null;
	}

	public static byte[] DoFinal(IDigest digest, byte[] input)
	{
		return null;
	}

	public static byte[] DoFinal(IDigest digest, byte[] buf, int off, int len)
	{
		return null;
	}

	public static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IDigest GetDigest(DerObjectIdentifier id)
	{
		return null;
	}

	public static IDigest GetDigest(string algorithm)
	{
		return null;
	}

	private static IDigest GetDigestForMechanism(string mechanism)
	{
		return null;
	}

	private static string GetMechanism(string algorithm)
	{
		return null;
	}

	public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
	{
		return null;
	}
}
