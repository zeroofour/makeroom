using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkcs;

public class Pkcs12Store
{
	internal struct CertID : IEquatable<CertID>
	{
		private readonly byte[] m_id = null;

		internal byte[] ID => null;

		internal CertID(X509CertificateEntry certEntry)
		{
		}

		internal CertID(X509Certificate cert)
		{
		}

		internal CertID(byte[] id)
		{
		}

		public bool Equals(CertID other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public const string IgnoreUselessPasswordProperty = "Mirror.BouncyCastle.Pkcs12.IgnoreUselessPassword";

	private readonly Dictionary<string, AsymmetricKeyEntry> m_keys;

	private readonly List<string> m_keysOrder;

	private readonly Dictionary<string, string> m_localIds;

	private readonly Dictionary<string, X509CertificateEntry> m_certs;

	private readonly List<string> m_certsOrder;

	private readonly Dictionary<CertID, X509CertificateEntry> m_chainCerts;

	private readonly List<CertID> m_chainCertsOrder;

	private readonly Dictionary<string, X509CertificateEntry> m_keyCerts;

	private readonly DerObjectIdentifier keyAlgorithm;

	private readonly DerObjectIdentifier keyPrfAlgorithm;

	private readonly DerObjectIdentifier certAlgorithm;

	private readonly bool useDerEncoding;

	private readonly bool reverseCertificates;

	private AsymmetricKeyEntry unmarkedKeyEntry;

	private const int MinIterations = 1024;

	private const int SaltSize = 20;

	public IEnumerable<string> Aliases => null;

	public int Count => 0;

	private static SubjectKeyIdentifier CreateSubjectKeyID(AsymmetricKeyParameter pubKey)
	{
		return null;
	}

	internal Pkcs12Store(DerObjectIdentifier keyAlgorithm, DerObjectIdentifier keyPrfAlgorithm, DerObjectIdentifier certAlgorithm, bool useDerEncoding, bool reverseCertificates)
	{
	}

	protected virtual void LoadKeyBag(PrivateKeyInfo privKeyInfo, Asn1Set bagAttributes)
	{
	}

	protected virtual void LoadPkcs8ShroudedKeyBag(EncryptedPrivateKeyInfo encPrivKeyInfo, Asn1Set bagAttributes, char[] password, bool wrongPkcs12Zero)
	{
	}

	public void Load(Stream input, char[] password)
	{
	}

	public AsymmetricKeyEntry GetKey(string alias)
	{
		return null;
	}

	public bool IsCertificateEntry(string alias)
	{
		return false;
	}

	public bool IsKeyEntry(string alias)
	{
		return false;
	}

	public bool ContainsAlias(string alias)
	{
		return false;
	}

	public X509CertificateEntry GetCertificate(string alias)
	{
		return null;
	}

	public string GetCertificateAlias(X509Certificate cert)
	{
		return null;
	}

	public X509CertificateEntry[] GetCertificateChain(string alias)
	{
		return null;
	}

	public void SetCertificateEntry(string alias, X509CertificateEntry certEntry)
	{
	}

	public void SetKeyEntry(string alias, AsymmetricKeyEntry keyEntry, X509CertificateEntry[] chain)
	{
	}

	public void DeleteEntry(string alias)
	{
	}

	public bool IsEntryOfType(string alias, Type entryType)
	{
		return false;
	}

	public void Save(Stream stream, char[] password, SecureRandom random)
	{
	}

	internal static byte[] CalculatePbeMac(DerObjectIdentifier oid, byte[] salt, int itCount, char[] password, bool wrongPkcs12Zero, byte[] data)
	{
		return null;
	}

	private static byte[] CryptPbeData(bool forEncryption, AlgorithmIdentifier algId, char[] password, bool wrongPkcs12Zero, byte[] data)
	{
		return null;
	}

	private static void Clear<K, V>(Dictionary<K, V> d, List<K> o)
	{
	}

	private static void Map<K, V>(Dictionary<K, V> d, List<K> o, K k, V v)
	{
	}

	private static bool Remove<K, V>(Dictionary<K, V> d, List<K> o, K k)
	{
		return false;
	}

	private static bool Remove<K, V>(Dictionary<K, V> d, List<K> o, K k, out V v)
	{
		v = default;
		return false;
	}

	private static void RemoveOrdering<K>(IEqualityComparer<K> c, List<K> o, K k)
	{
	}
}
