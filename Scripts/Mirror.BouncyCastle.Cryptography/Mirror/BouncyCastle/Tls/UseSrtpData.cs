namespace Mirror.BouncyCastle.Tls;

public sealed class UseSrtpData
{
	private readonly int[] m_protectionProfiles;

	private readonly byte[] m_mki;

	public int[] ProtectionProfiles => null;

	public byte[] Mki => null;

	public UseSrtpData(int[] protectionProfiles, byte[] mki)
	{
	}
}
