using System.Collections.Generic;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpEncryptedDataList : PgpObject
{
	private readonly List<PgpEncryptedData> m_list;

	private readonly InputStreamPacket m_data;

	public PgpEncryptedData this[int index] => null;

	public int Count => 0;

	public bool IsEmpty => false;

	public PgpEncryptedDataList(BcpgInputStream bcpgInput)
	{
	}

	public IEnumerable<PgpEncryptedData> GetEncryptedDataObjects()
	{
		return null;
	}
}
