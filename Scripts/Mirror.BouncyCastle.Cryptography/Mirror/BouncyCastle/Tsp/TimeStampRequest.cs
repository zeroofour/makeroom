using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Tsp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Tsp;

public class TimeStampRequest : X509ExtensionBase
{
	private TimeStampReq req;

	public int Version => 0;

	public string MessageImprintAlgOid => null;

	public string ReqPolicy => null;

	public BigInteger Nonce => null;

	public bool CertReq => false;

	internal X509Extensions Extensions => null;

	public virtual bool HasExtensions => false;

	public TimeStampRequest(TimeStampReq req)
	{
	}

	public TimeStampRequest(byte[] req)
	{
	}

	public TimeStampRequest(Stream input)
	{
	}

	private TimeStampRequest(Asn1InputStream str)
	{
	}

	public byte[] GetMessageImprintDigest()
	{
		return null;
	}

	public void Validate(IList<string> algorithms, IList<string> policies, IList<string> extensions)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public virtual IList<DerObjectIdentifier> GetExtensionOids()
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}
}
