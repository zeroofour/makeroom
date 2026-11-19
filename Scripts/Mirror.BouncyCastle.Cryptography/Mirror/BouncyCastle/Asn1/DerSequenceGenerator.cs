using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public class DerSequenceGenerator : DerGenerator
{
	private readonly MemoryStream _bOut;

	public DerSequenceGenerator(Stream outStream)
		: base(null)
	{
	}

	public DerSequenceGenerator(Stream outStream, int tagNo, bool isExplicit)
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
}
