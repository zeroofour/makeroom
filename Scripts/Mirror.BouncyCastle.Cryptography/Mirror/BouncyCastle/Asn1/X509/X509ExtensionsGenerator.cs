using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class X509ExtensionsGenerator
{
	private Dictionary<DerObjectIdentifier, X509Extension> m_extensions;

	private List<DerObjectIdentifier> m_ordering;

	private static readonly HashSet<DerObjectIdentifier> m_dupsAllowed;

	public bool IsEmpty => false;

	public void Reset()
	{
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extValue)
	{
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extValue)
	{
	}

	public void AddExtensions(X509Extensions extensions)
	{
	}

	public X509Extensions Generate()
	{
		return null;
	}

	internal void AddExtension(DerObjectIdentifier oid, X509Extension x509Extension)
	{
	}
}
