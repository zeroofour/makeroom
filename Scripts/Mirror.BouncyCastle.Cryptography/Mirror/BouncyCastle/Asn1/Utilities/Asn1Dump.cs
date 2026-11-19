using System.IO;
using System.Text;

namespace Mirror.BouncyCastle.Asn1.Utilities;

public static class Asn1Dump
{
	private const string Tab = "    ";

	private const int SampleSize = 32;

	private static void AsString(string indent, bool verbose, Asn1Object obj, StringBuilder buf)
	{
	}

	public static void Dump(Stream input, TextWriter output)
	{
	}

	public static string DumpAsString(Asn1Encodable obj)
	{
		return null;
	}

	public static string DumpAsString(Asn1Encodable obj, bool verbose)
	{
		return null;
	}

	private static void DumpBinaryDataAsString(StringBuilder buf, string indent, byte[] bytes)
	{
	}

	private static void AppendAscString(StringBuilder buf, byte[] bytes, int off, int len)
	{
	}
}
