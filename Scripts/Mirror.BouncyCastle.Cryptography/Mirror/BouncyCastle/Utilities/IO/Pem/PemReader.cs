using System;
using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO.Pem;

public class PemReader : IDisposable
{
	private const int LineLength = 64;

	private readonly TextReader m_reader;

	private readonly MemoryStream m_buffer;

	private readonly StreamWriter m_textBuffer;

	private readonly Stack<int> m_pushback;

	public TextReader Reader => null;

	public PemReader(TextReader reader)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public PemObject ReadPemObject()
	{
		return null;
	}

	private string BufferedString()
	{
		return null;
	}

	private bool SeekDash()
	{
		return false;
	}

	private bool SeekColon(int upTo)
	{
		return false;
	}

	private bool ConsumeDash()
	{
		return false;
	}

	private void SkipWhiteSpace()
	{
	}

	private bool Expect(string value)
	{
		return false;
	}

	private bool BufferUntilStopChar(char stopChar, bool skipWhiteSpace)
	{
		return false;
	}

	private void PushBack(int value)
	{
	}

	private int Read()
	{
		return 0;
	}
}
