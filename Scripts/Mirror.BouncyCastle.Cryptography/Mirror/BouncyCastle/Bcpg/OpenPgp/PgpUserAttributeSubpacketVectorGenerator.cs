using System.Collections.Generic;
using Mirror.BouncyCastle.Bcpg.Attr;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpUserAttributeSubpacketVectorGenerator
{
	private readonly List<UserAttributeSubpacket> list;

	public virtual void SetImageAttribute(ImageAttrib.Format imageType, byte[] imageData)
	{
	}

	public virtual PgpUserAttributeSubpacketVector Generate()
	{
		return null;
	}
}
