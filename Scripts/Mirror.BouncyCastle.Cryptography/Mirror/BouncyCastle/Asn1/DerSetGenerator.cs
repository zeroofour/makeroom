using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public class DerSetGenerator : DerGenerator
{
	private readonly MemoryStream _bOut;

	public DerSetGenerator(Stream outStream)
		: base(null)
	{
	}

	public DerSetGenerator(Stream outStream, int tagNo, bool isExplicit)
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
