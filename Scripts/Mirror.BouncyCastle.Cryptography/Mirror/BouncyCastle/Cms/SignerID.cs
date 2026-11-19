using System;
using Mirror.BouncyCastle.X509.Store;

namespace Mirror.BouncyCastle.Cms;

public class SignerID : X509CertStoreSelector, IEquatable<SignerID>
{
	public virtual bool Equals(SignerID other)
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
