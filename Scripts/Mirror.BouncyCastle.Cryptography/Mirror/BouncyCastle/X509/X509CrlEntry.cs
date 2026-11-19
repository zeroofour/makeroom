using System;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.X509;

public class X509CrlEntry : X509ExtensionBase
{
	private CrlEntry c;

	private bool isIndirect;

	private X509Name previousCertificateIssuer;

	private X509Name certificateIssuer;

	private bool hashValueSet;

	private int hashValue;

	public BigInteger SerialNumber => null;

	public DateTime RevocationDate => default;

	public bool HasExtensions => false;

	public X509CrlEntry(CrlEntry c)
	{
	}

	public X509CrlEntry(CrlEntry c, bool isIndirect, X509Name previousCertificateIssuer)
	{
	}

	private X509Name loadCertificateIssuer()
	{
		return null;
	}

	public X509Name GetCertificateIssuer()
	{
		return null;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
