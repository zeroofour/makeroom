using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class CipherUtilities
{
	private enum CipherAlgorithm
	{
		AES = 0,
		ARC4 = 1,
		ARIA = 2,
		BLOWFISH = 3,
		CAMELLIA = 4,
		CAST5 = 5,
		CAST6 = 6,
		CHACHA = 7,
		CHACHA20_POLY1305 = 8,
		CHACHA7539 = 9,
		DES = 10,
		DESEDE = 11,
		ELGAMAL = 12,
		GOST28147 = 13,
		HC128 = 14,
		HC256 = 15,
		IDEA = 16,
		NOEKEON = 17,
		PBEWITHSHAAND128BITRC4 = 18,
		PBEWITHSHAAND40BITRC4 = 19,
		RC2 = 20,
		RC5 = 21,
		RC5_64 = 22,
		RC6 = 23,
		RIJNDAEL = 24,
		RSA = 25,
		SALSA20 = 26,
		SEED = 27,
		SERPENT = 28,
		SKIPJACK = 29,
		SM4 = 30,
		TEA = 31,
		THREEFISH_256 = 32,
		THREEFISH_512 = 33,
		THREEFISH_1024 = 34,
		TNEPRES = 35,
		TWOFISH = 36,
		VMPC = 37,
		VMPC_KSA3 = 38,
		XTEA = 39
	}

	private enum CipherMode
	{
		ECB = 0,
		NONE = 1,
		CBC = 2,
		CCM = 3,
		CFB = 4,
		CTR = 5,
		CTS = 6,
		EAX = 7,
		GCM = 8,
		GOFB = 9,
		OCB = 10,
		OFB = 11,
		OPENPGPCFB = 12,
		SIC = 13
	}

	private enum CipherPadding
	{
		NOPADDING = 0,
		RAW = 1,
		ISO10126PADDING = 2,
		ISO10126D2PADDING = 3,
		ISO10126_2PADDING = 4,
		ISO7816_4PADDING = 5,
		ISO9797_1PADDING = 6,
		ISO9796_1 = 7,
		ISO9796_1PADDING = 8,
		OAEP = 9,
		OAEPPADDING = 10,
		OAEPWITHMD5ANDMGF1PADDING = 11,
		OAEPWITHSHA1ANDMGF1PADDING = 12,
		OAEPWITHSHA_1ANDMGF1PADDING = 13,
		OAEPWITHSHA224ANDMGF1PADDING = 14,
		OAEPWITHSHA_224ANDMGF1PADDING = 15,
		OAEPWITHSHA256ANDMGF1PADDING = 16,
		OAEPWITHSHA_256ANDMGF1PADDING = 17,
		OAEPWITHSHA256ANDMGF1WITHSHA256PADDING = 18,
		OAEPWITHSHA_256ANDMGF1WITHSHA_256PADDING = 19,
		OAEPWITHSHA256ANDMGF1WITHSHA1PADDING = 20,
		OAEPWITHSHA_256ANDMGF1WITHSHA_1PADDING = 21,
		OAEPWITHSHA384ANDMGF1PADDING = 22,
		OAEPWITHSHA_384ANDMGF1PADDING = 23,
		OAEPWITHSHA512ANDMGF1PADDING = 24,
		OAEPWITHSHA_512ANDMGF1PADDING = 25,
		PKCS1 = 26,
		PKCS1PADDING = 27,
		PKCS5 = 28,
		PKCS5PADDING = 29,
		PKCS7 = 30,
		PKCS7PADDING = 31,
		TBCPADDING = 32,
		WITHCTS = 33,
		X923PADDING = 34,
		ZEROBYTEPADDING = 35
	}

	private static readonly Dictionary<string, string> AlgorithmMap;

	private static readonly Dictionary<DerObjectIdentifier, string> AlgorithmOidMap;

	static CipherUtilities()
	{
	}

	public static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IBufferedCipher GetCipher(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IBufferedCipher GetCipher(string algorithm)
	{
		return null;
	}

	private static IBufferedCipher GetCipherForMechanism(string mechanism)
	{
		return null;
	}

	private static int GetDigitIndex(string s)
	{
		return 0;
	}

	private static string GetMechanism(string algorithm)
	{
		return null;
	}

	private static IBlockCipher CreateBlockCipher(CipherAlgorithm cipherAlgorithm)
	{
		return null;
	}
}
