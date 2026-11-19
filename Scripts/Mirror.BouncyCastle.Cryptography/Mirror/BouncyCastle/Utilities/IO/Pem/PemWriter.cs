using System;
using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO.Pem;

public class PemWriter : IDisposable
{
	private const int LineLength = 64;

	private readonly TextWriter m_writer;

	private readonly int m_nlLength;

	private readonly char[] m_buf;

	public TextWriter Writer => null;

	public PemWriter(TextWriter writer)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public int GetOutputSize(PemObject obj)
	{
		return 0;
	}

	public void WriteObject(PemObjectGenerator objGen)
	{
	}

	private void WriteEncoded(byte[] bytes)
	{
	}

	private void WritePreEncapsulationBoundary(string type)
	{
	}

	private void WritePostEncapsulationBoundary(string type)
	{
	}
}
