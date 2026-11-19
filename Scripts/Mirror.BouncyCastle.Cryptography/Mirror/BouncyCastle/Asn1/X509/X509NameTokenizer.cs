namespace Mirror.BouncyCastle.Asn1.X509;

public class X509NameTokenizer
{
	private readonly string m_value;

	private readonly char m_separator;

	private int m_index;

	public X509NameTokenizer(string oid)
	{
	}

	public X509NameTokenizer(string oid, char separator)
	{
	}

	public bool HasMoreTokens()
	{
		return false;
	}

	public string NextToken()
	{
		return null;
	}
}
