using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.X509;

public abstract class X509ExtensionBase : IX509Extension
{
	protected abstract X509Extensions GetX509Extensions();

	protected virtual ISet<string> GetExtensionOids(bool critical)
	{
		return null;
	}

	public virtual ISet<string> GetNonCriticalExtensionOids()
	{
		return null;
	}

	public virtual ISet<string> GetCriticalExtensionOids()
	{
		return null;
	}

	public virtual X509Extension GetExtension(DerObjectIdentifier oid)
	{
		return null;
	}

	public virtual Asn1Object GetExtensionParsedValue(DerObjectIdentifier oid)
	{
		return null;
	}

	public virtual Asn1OctetString GetExtensionValue(DerObjectIdentifier oid)
	{
		return null;
	}
}
