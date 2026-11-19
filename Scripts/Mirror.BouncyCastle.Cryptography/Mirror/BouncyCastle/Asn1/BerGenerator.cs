using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public abstract class BerGenerator : Asn1Generator
{
	private bool _tagged;

	private bool _isExplicit;

	private int _tagNo;

	protected BerGenerator(Stream outStream)
		: base(null)
	{
	}

	protected BerGenerator(Stream outStream, int tagNo, bool isExplicit)
		: base(null)
	{
	}

	protected override void Finish()
	{
	}

	public override void AddObject(Asn1Encodable obj)
	{
	}

	public override void AddObject(Asn1Object obj)
	{
	}

	public override Stream GetRawOutputStream()
	{
		return null;
	}

	private void WriteHdr(int tag)
	{
	}

	protected void WriteBerHeader(int tag)
	{
	}

	protected void WriteBerBody(Stream contentStream)
	{
	}

	protected void WriteBerEnd()
	{
	}
}
