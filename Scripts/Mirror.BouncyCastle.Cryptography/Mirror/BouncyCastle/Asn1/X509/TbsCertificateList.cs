using System;
using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class TbsCertificateList : Asn1Encodable
{
	private class RevokedCertificatesEnumeration : IEnumerable<CrlEntry>, IEnumerable
	{
		private sealed class RevokedCertificatesEnumerator : IEnumerator<CrlEntry>, IEnumerator, IDisposable
		{
			private readonly IEnumerator<Asn1Encodable> e;

			object IEnumerator.Current => null;

			public CrlEntry Current => null;

			internal RevokedCertificatesEnumerator(IEnumerator<Asn1Encodable> e)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private readonly IEnumerable<Asn1Encodable> en;

		internal RevokedCertificatesEnumeration(IEnumerable<Asn1Encodable> en)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<CrlEntry> GetEnumerator()
		{
			return null;
		}
	}

	internal Asn1Sequence seq;

	internal DerInteger version;

	internal AlgorithmIdentifier signature;

	internal X509Name issuer;

	internal Time thisUpdate;

	internal Time nextUpdate;

	internal Asn1Sequence revokedCertificates;

	internal X509Extensions crlExtensions;

	public int Version => 0;

	public DerInteger VersionNumber => null;

	public AlgorithmIdentifier Signature => null;

	public X509Name Issuer => null;

	public Time ThisUpdate => null;

	public Time NextUpdate => null;

	public X509Extensions Extensions => null;

	public static TbsCertificateList GetInstance(object obj)
	{
		return null;
	}

	public static TbsCertificateList GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	private TbsCertificateList(Asn1Sequence seq)
	{
	}

	public CrlEntry[] GetRevokedCertificates()
	{
		return null;
	}

	public IEnumerable<CrlEntry> GetRevokedCertificateEnumeration()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
