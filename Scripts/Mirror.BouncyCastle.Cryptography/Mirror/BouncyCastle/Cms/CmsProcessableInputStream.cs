using System.IO;

namespace Mirror.BouncyCastle.Cms;

public class CmsProcessableInputStream : CmsProcessable, CmsReadable
{
	private readonly Stream input;

	private bool used;

	public CmsProcessableInputStream(Stream input)
	{
	}

	public virtual Stream GetInputStream()
	{
		return null;
	}

	public virtual void Write(Stream output)
	{
	}

	protected virtual void CheckSingleUsage()
	{
	}
}
