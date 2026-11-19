using System;
using Mirror.BouncyCastle.X509.Store;

namespace Mirror.BouncyCastle.Cms;

public class OriginatorID : X509CertStoreSelector, IEquatable<OriginatorID>
{
	public virtual bool Equals(OriginatorID other)
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
