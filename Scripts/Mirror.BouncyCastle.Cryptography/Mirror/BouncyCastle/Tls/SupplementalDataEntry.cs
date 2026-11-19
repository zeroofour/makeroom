namespace Mirror.BouncyCastle.Tls;

public sealed class SupplementalDataEntry
{
	private readonly int m_dataType;

	private readonly byte[] m_data;

	public int DataType => 0;

	public byte[] Data => null;

	public SupplementalDataEntry(int dataType, byte[] data)
	{
	}
}
