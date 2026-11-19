using System;
using System.IO;
using Mirror.BouncyCastle.Asn1.Cms;

namespace Mirror.BouncyCastle.Cms;

public class CmsContentInfoParser : IDisposable
{
	protected ContentInfoParser contentInfo;

	protected Stream data;

	protected CmsContentInfoParser(Stream data)
	{
	}

	[Obsolete("Dispose instead")]
	public void Close()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
