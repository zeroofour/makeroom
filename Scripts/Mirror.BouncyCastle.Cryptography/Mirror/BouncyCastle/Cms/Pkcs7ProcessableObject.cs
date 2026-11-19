using System.IO;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Cms;

public class Pkcs7ProcessableObject : CmsProcessable
{
	public DerObjectIdentifier ContentType { get; }

	public Asn1Encodable Content { get; }

	public Pkcs7ProcessableObject(DerObjectIdentifier contentType, Asn1Encodable content)
	{
	}

	public void Write(Stream outStream)
	{
	}

	public object GetContent()
	{
		return null;
	}
}
