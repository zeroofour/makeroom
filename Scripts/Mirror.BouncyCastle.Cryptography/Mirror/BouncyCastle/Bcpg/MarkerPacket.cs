namespace Mirror.BouncyCastle.Bcpg;

public class MarkerPacket : ContainedPacket
{
	private readonly byte[] marker;

	public MarkerPacket(BcpgInputStream bcpgIn)
	{
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}
}
