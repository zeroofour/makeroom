using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class CertificateEntry
{
	private readonly TlsCertificate m_certificate;

	private readonly IDictionary<int, byte[]> m_extensions;

	public TlsCertificate Certificate => null;

	public IDictionary<int, byte[]> Extensions => null;

	public CertificateEntry(TlsCertificate certificate, IDictionary<int, byte[]> extensions)
	{
	}
}
