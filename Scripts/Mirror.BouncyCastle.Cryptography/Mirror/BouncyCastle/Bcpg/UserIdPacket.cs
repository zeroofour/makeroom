namespace Mirror.BouncyCastle.Bcpg;

public class UserIdPacket : ContainedPacket, IUserDataPacket
{
	private readonly byte[] idData;

	public UserIdPacket(BcpgInputStream bcpgIn)
	{
	}

	public UserIdPacket(string id)
	{
	}

	public UserIdPacket(byte[] rawId)
	{
	}

	public string GetId()
	{
		return null;
	}

	public byte[] GetRawId()
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

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}
}
