using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public abstract class DerGenerator : Asn1Generator
{
	private bool _tagged;

	private bool _isExplicit;

	private int _tagNo;

	protected DerGenerator(Stream outStream)
		: base(null)
	{
	}

	protected DerGenerator(Stream outStream, int tagNo, bool isExplicit)
		: base(null)
	{
	}

	internal void WriteDerEncoded(int tag, byte[] bytes)
	{
	}

	internal static void WriteDerEncoded(Stream outStream, int tag, byte[] bytes)
	{
	}

	internal static void WriteDerEncoded(Stream outStream, int tag, Stream inStream)
	{
	}

	private static void WriteLength(Stream outStream, int length)
	{
	}
}
