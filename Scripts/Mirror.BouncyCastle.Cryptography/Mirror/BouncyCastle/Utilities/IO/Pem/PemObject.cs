using System.Collections.Generic;

namespace Mirror.BouncyCastle.Utilities.IO.Pem;

public class PemObject : PemObjectGenerator
{
	private readonly string m_type;

	private readonly IList<PemHeader> m_headers;

	private readonly byte[] m_content;

	public string Type => null;

	public IList<PemHeader> Headers => null;

	public byte[] Content => null;

	public PemObject(string type, byte[] content)
	{
	}

	public PemObject(string type, IList<PemHeader> headers, byte[] content)
	{
	}

	public PemObject Generate()
	{
		return null;
	}
}
