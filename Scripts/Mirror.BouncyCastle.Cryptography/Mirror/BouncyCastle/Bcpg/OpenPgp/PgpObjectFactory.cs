using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpObjectFactory
{
	private readonly BcpgInputStream bcpgIn;

	public PgpObjectFactory(Stream inputStream)
	{
	}

	public PgpObjectFactory(byte[] bytes)
	{
	}

	public PgpObject NextPgpObject()
	{
		return null;
	}

	public IList<PgpObject> AllPgpObjects()
	{
		return null;
	}

	public IList<T> FilterPgpObjects<T>() where T : PgpObject
	{
		return null;
	}
}
