using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Bcpg;

public class ArmoredInputStream : BaseInputStream
{
	private static readonly byte[] decodingTable;

	private bool detectMissingChecksum;

	private Stream input;

	private bool start;

	private byte[] outBuf;

	private int bufPtr;

	private Crc24 crc;

	private bool crcFound;

	private bool hasHeaders;

	private string header;

	private bool newLineFound;

	private bool clearText;

	private bool restart;

	private IList<string> headerList;

	private int lastC;

	private bool isEndOfStream;

	static ArmoredInputStream()
	{
	}

	private static int Decode(int in0, int in1, int in2, int in3, byte[] result)
	{
		return 0;
	}

	public ArmoredInputStream(Stream input)
	{
	}

	public ArmoredInputStream(Stream input, bool hasHeaders)
	{
	}

	private bool ParseHeaders()
	{
		return false;
	}

	public bool IsClearText()
	{
		return false;
	}

	public bool IsEndOfStream()
	{
		return false;
	}

	public string GetArmorHeaderLine()
	{
		return null;
	}

	public string[] GetArmorHeaders()
	{
		return null;
	}

	private int ReadIgnoreSpace()
	{
		return 0;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	protected override void Dispose(bool disposing)
	{
	}

	public virtual void SetDetectMissingCrc(bool detectMissing)
	{
	}
}
