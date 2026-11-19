namespace Mirror.BouncyCastle.Bcpg;

public sealed class Crc24
{
	private const int Crc24Init = 11994318;

	private const int Crc24Poly = 25578747;

	private static readonly int[] Table0;

	private static readonly int[] Table8;

	private static readonly int[] Table16;

	private int m_crc;

	public int Value => 0;

	static Crc24()
	{
	}

	public void Update(byte b)
	{
	}

	public void Update3(byte[] buf, int off)
	{
	}

	public void Reset()
	{
	}
}
