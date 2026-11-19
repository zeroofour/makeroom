using System;
using Mirror.BouncyCastle.X509.Store;

namespace Mirror.BouncyCastle.Cms;

public class RecipientID : X509CertStoreSelector, IEquatable<RecipientID>
{
	private byte[] m_keyIdentifier;

	public byte[] KeyIdentifier
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool Equals(RecipientID other)
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
