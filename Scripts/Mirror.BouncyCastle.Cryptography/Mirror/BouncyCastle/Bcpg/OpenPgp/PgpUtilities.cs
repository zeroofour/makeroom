using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public sealed class PgpUtilities
{
	private static readonly IDictionary<string, HashAlgorithmTag> NameToHashID;

	private static readonly IDictionary<DerObjectIdentifier, string> OidToName;

	private const int ReadAhead = 60;

	private static IDictionary<string, HashAlgorithmTag> CreateNameToHashID()
	{
		return null;
	}

	private static IDictionary<DerObjectIdentifier, string> CreateOidToName()
	{
		return null;
	}

	public static MPInteger[] DsaSigToMpi(byte[] encoding)
	{
		return null;
	}

	public static MPInteger[] RsaSigToMpi(byte[] encoding)
	{
		return null;
	}

	public static string GetDigestName(HashAlgorithmTag hashAlgorithm)
	{
		return null;
	}

	public static int GetDigestIDForName(string name)
	{
		return 0;
	}

	public static string GetCurveName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static string GetSignatureName(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
	{
		return null;
	}

	public static string GetSymmetricCipherName(SymmetricKeyAlgorithmTag algorithm)
	{
		return null;
	}

	public static int GetKeySize(SymmetricKeyAlgorithmTag algorithm)
	{
		return 0;
	}

	public static KeyParameter MakeKey(SymmetricKeyAlgorithmTag algorithm, byte[] keyBytes)
	{
		return null;
	}

	public static KeyParameter MakeRandomKey(SymmetricKeyAlgorithmTag algorithm, SecureRandom random)
	{
		return null;
	}

	internal static byte[] EncodePassPhrase(char[] passPhrase, bool utf8)
	{
		return null;
	}

	public static KeyParameter MakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
	{
		return null;
	}

	public static KeyParameter MakeKeyFromPassPhraseUtf8(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
	{
		return null;
	}

	public static KeyParameter MakeKeyFromPassPhraseRaw(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase)
	{
		return null;
	}

	internal static KeyParameter DoMakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase, bool clearPassPhrase)
	{
		return null;
	}

	public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file)
	{
	}

	public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file, byte[] buffer)
	{
	}

	private static void PipeFileContents(FileInfo file, Stream pOut)
	{
	}

	private static void PipeFileContents(FileInfo file, Stream pOut, int bufferSize)
	{
	}

	private static bool IsPossiblyBase64(int ch)
	{
		return false;
	}

	public static Stream GetDecoderStream(Stream inputStream)
	{
		return null;
	}

	internal static IDigest CreateDigest(HashAlgorithmTag hashAlgorithm)
	{
		return null;
	}

	internal static ISigner CreateSigner(PublicKeyAlgorithmTag publicKeyAlgorithm, HashAlgorithmTag hashAlgorithm, AsymmetricKeyParameter key)
	{
		return null;
	}

	internal static IWrapper CreateWrapper(SymmetricKeyAlgorithmTag encAlgorithm)
	{
		return null;
	}

	internal static byte[] GenerateIV(int length, SecureRandom random)
	{
		return null;
	}

	internal static S2k GenerateS2k(HashAlgorithmTag hashAlgorithm, int s2kCount, SecureRandom random)
	{
		return null;
	}
}
