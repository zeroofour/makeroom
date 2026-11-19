using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Bcpg;

public class ArmoredOutputStream : BaseOutputStream
{
	public static readonly string HeaderVersion;

	private static readonly byte[] encodingTable;

	private readonly Stream outStream;

	private byte[] buf;

	private int bufPtr;

	private Crc24 crc;

	private int chunkCount;

	private int lastb;

	private bool start;

	private bool clearText;

	private bool newLine;

	private string type;

	private static readonly string NewLine;

	private static readonly string headerStart;

	private static readonly string headerTail;

	private static readonly string footerStart;

	private static readonly string footerTail;

	private static readonly string Version;

	private readonly Dictionary<string, List<string>> m_headers;

	private static void Encode(Stream outStream, byte[] data, int len)
	{
	}

	private static void Encode3(Stream outStream, byte[] data)
	{
	}

	private static string CreateVersion()
	{
		return null;
	}

	public ArmoredOutputStream(Stream outStream)
	{
	}

	public ArmoredOutputStream(Stream outStream, bool addVersionHeader)
	{
	}

	public ArmoredOutputStream(Stream outStream, IDictionary<string, string> headers)
	{
	}

	public ArmoredOutputStream(Stream outStream, IDictionary<string, string> headers, bool addVersionHeader)
	{
	}

	public void SetHeader(string name, string val)
	{
	}

	public void AddHeader(string name, string val)
	{
	}

	public void ResetHeaders()
	{
	}

	public void BeginClearText(HashAlgorithmTag hashAlgorithm)
	{
	}

	public void EndClearText()
	{
	}

	public override void WriteByte(byte value)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void DoClose()
	{
	}

	private void WriteHeaderEntry(string name, string v)
	{
	}

	private void DoWrite(string s)
	{
	}
}
