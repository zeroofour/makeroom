using System;
using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Generator : IDisposable
{
	private Stream m_outStream;

	protected Stream OutStream => null;

	protected Asn1Generator(Stream outStream)
	{
	}

	protected abstract void Finish();

	public abstract void AddObject(Asn1Encodable obj);

	public abstract void AddObject(Asn1Object obj);

	public abstract Stream GetRawOutputStream();

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
