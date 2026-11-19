namespace Mirror.BouncyCastle.Bcpg;

public class ExperimentalPacket : ContainedPacket
{
	private readonly PacketTag m_tag;

	private readonly byte[] m_contents;

	public PacketTag Tag => PacketTag.Reserved;

	internal ExperimentalPacket(PacketTag tag, BcpgInputStream bcpgIn)
	{
	}

	public byte[] GetContents()
	{
		return null;
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}
}
