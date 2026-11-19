using System.IO;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Cms;

public class CmsProcessableByteArray : CmsProcessable, CmsReadable
{
	private readonly DerObjectIdentifier type;

	private readonly byte[] bytes;

	public DerObjectIdentifier Type => null;

	public CmsProcessableByteArray(byte[] bytes)
	{
	}

	public CmsProcessableByteArray(DerObjectIdentifier type, byte[] bytes)
	{
	}

	public virtual Stream GetInputStream()
	{
		return null;
	}

	public virtual void Write(Stream zOut)
	{
	}
}
