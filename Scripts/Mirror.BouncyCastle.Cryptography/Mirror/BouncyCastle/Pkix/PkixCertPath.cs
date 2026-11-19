using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class PkixCertPath
{
	private static readonly List<string> EncodingNames;

	private readonly IList<X509Certificate> m_certificates;

	public virtual IEnumerable<string> Encodings => null;

	public virtual IList<X509Certificate> Certificates => null;

	private static IList<X509Certificate> SortCerts(IList<X509Certificate> certs)
	{
		return null;
	}

	public PkixCertPath(IList<X509Certificate> certificates)
	{
	}

	public PkixCertPath(Stream inStream)
	{
	}

	public PkixCertPath(Stream inStream, string encoding)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public virtual byte[] GetEncoded()
	{
		return null;
	}

	public virtual byte[] GetEncoded(string encoding)
	{
		return null;
	}

	private Asn1Object ToAsn1Object(X509Certificate cert)
	{
		return null;
	}

	private byte[] ToDerEncoded(Asn1Encodable obj)
	{
		return null;
	}
}
