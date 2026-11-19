using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Security;

public class JksStore
{
	private sealed class JksTrustedCertEntry
	{
		internal readonly DateTime date;

		internal readonly X509Certificate cert;

		internal JksTrustedCertEntry(DateTime date, X509Certificate cert)
		{
		}
	}

	private sealed class JksKeyEntry
	{
		internal readonly DateTime date;

		internal readonly EncryptedPrivateKeyInfo keyData;

		internal readonly X509Certificate[] chain;

		internal JksKeyEntry(DateTime date, byte[] keyData, X509Certificate[] chain)
		{
		}
	}

	private sealed class ErasableByteStream : MemoryStream
	{
		internal ErasableByteStream(byte[] buffer, int index, int count)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private static readonly int Magic;

	private static readonly AlgorithmIdentifier JksObfuscationAlg;

	private readonly Dictionary<string, JksTrustedCertEntry> m_certificateEntries;

	private readonly Dictionary<string, JksKeyEntry> m_keyEntries;

	public IEnumerable<string> Aliases => null;

	public int Count => 0;

	public bool Probe(Stream stream)
	{
		return false;
	}

	public AsymmetricKeyParameter GetKey(string alias, char[] password)
	{
		return null;
	}

	private byte[] GetKeyChecksum(IDigest digest, char[] password, byte[] pkcs8Key)
	{
		return null;
	}

	private byte[] CalculateKeyStream(IDigest digest, char[] password, byte[] salt, int count)
	{
		return null;
	}

	public X509Certificate[] GetCertificateChain(string alias)
	{
		return null;
	}

	public X509Certificate GetCertificate(string alias)
	{
		return null;
	}

	public DateTime? GetCreationDate(string alias)
	{
		return null;
	}

	public void SetKeyEntry(string alias, AsymmetricKeyParameter key, char[] password, X509Certificate[] chain)
	{
	}

	public void SetKeyEntry(string alias, byte[] key, X509Certificate[] chain)
	{
	}

	public void SetCertificateEntry(string alias, X509Certificate cert)
	{
	}

	public void DeleteEntry(string alias)
	{
	}

	public bool ContainsAlias(string alias)
	{
		return false;
	}

	public bool IsKeyEntry(string alias)
	{
		return false;
	}

	public bool IsCertificateEntry(string alias)
	{
		return false;
	}

	public string GetCertificateAlias(X509Certificate cert)
	{
		return null;
	}

	public void Save(Stream stream, char[] password)
	{
	}

	private void SaveStream(Stream stream, IDigest checksumDigest)
	{
	}

	public void Load(Stream stream, char[] password)
	{
	}

	public void LoadUnchecked(Stream stream)
	{
	}

	private void LoadStream(ErasableByteStream storeStream)
	{
	}

	private ErasableByteStream ValidateStream(Stream inputStream, char[] password)
	{
		return null;
	}

	private static void AddPassword(IDigest digest, char[] password)
	{
	}

	private static byte[] CalculateChecksum(char[] password, byte[] buffer, int offset, int length)
	{
		return null;
	}

	private static X509Certificate[] CloneChain(X509Certificate[] chain)
	{
		return null;
	}

	private static string ConvertAlias(string alias)
	{
		return null;
	}

	private static IDigest CreateChecksumDigest(char[] password)
	{
		return null;
	}

	private static byte[] ReadBufferWithInt16Length(BinaryReader br)
	{
		return null;
	}

	private static byte[] ReadBufferWithInt32Length(BinaryReader br)
	{
		return null;
	}

	private static DateTime ReadDateTime(BinaryReader br)
	{
		return default;
	}

	private static X509Certificate ReadTypedCertificate(BinaryReader br, int storeVersion)
	{
		return null;
	}

	private static string ReadUtf(BinaryReader br)
	{
		return null;
	}

	private static void WriteBufferWithInt16Length(BinaryWriter bw, byte[] buffer)
	{
	}

	private static void WriteBufferWithInt32Length(BinaryWriter bw, byte[] buffer)
	{
	}

	private static void WriteDateTime(BinaryWriter bw, DateTime dateTime)
	{
	}

	private static void WriteTypedCertificate(BinaryWriter bw, X509Certificate cert)
	{
	}

	private static void WriteUtf(BinaryWriter bw, string s)
	{
	}
}
