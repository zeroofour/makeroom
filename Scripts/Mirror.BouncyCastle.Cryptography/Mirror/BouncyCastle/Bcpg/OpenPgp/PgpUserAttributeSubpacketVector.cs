using Mirror.BouncyCastle.Bcpg.Attr;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpUserAttributeSubpacketVector : IUserDataPacket
{
	private readonly UserAttributeSubpacket[] packets;

	public static PgpUserAttributeSubpacketVector FromSubpackets(UserAttributeSubpacket[] packets)
	{
		return null;
	}

	internal PgpUserAttributeSubpacketVector(UserAttributeSubpacket[] packets)
	{
	}

	public UserAttributeSubpacket GetSubpacket(UserAttributeSubpacketTag type)
	{
		return null;
	}

	public ImageAttrib GetImageAttribute()
	{
		return null;
	}

	internal UserAttributeSubpacket[] ToSubpacketArray()
	{
		return null;
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
