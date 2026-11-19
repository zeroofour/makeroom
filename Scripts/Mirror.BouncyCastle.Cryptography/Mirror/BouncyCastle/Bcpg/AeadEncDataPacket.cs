namespace Mirror.BouncyCastle.Bcpg;

public class AeadEncDataPacket : InputStreamPacket
{
	private readonly byte m_version;

	private readonly SymmetricKeyAlgorithmTag m_algorithm;

	private readonly AeadAlgorithmTag m_aeadAlgorithm;

	private readonly byte m_chunkSize;

	private readonly byte[] m_iv;

	public byte Version => 0;

	public SymmetricKeyAlgorithmTag Algorithm => SymmetricKeyAlgorithmTag.Null;

	public AeadAlgorithmTag AeadAlgorithm => (AeadAlgorithmTag)0;

	public int ChunkSize => 0;

	public AeadEncDataPacket(BcpgInputStream bcpgIn)
		: base(null)
	{
	}

	public AeadEncDataPacket(SymmetricKeyAlgorithmTag algorithm, AeadAlgorithmTag aeadAlgorithm, int chunkSize, byte[] iv)
		: base(null)
	{
	}

	public byte[] GetIV()
	{
		return null;
	}

	public static int GetIVLength(AeadAlgorithmTag aeadAlgorithm)
	{
		return 0;
	}
}
