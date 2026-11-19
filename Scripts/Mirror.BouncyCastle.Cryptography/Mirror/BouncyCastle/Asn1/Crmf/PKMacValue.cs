using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Crmf;

public class PKMacValue : Asn1Encodable
{
	private readonly AlgorithmIdentifier m_algID;

	private readonly DerBitString m_macValue;

	public virtual AlgorithmIdentifier AlgID => null;

	public virtual DerBitString MacValue => null;

	public static PKMacValue GetInstance(object obj)
	{
		return null;
	}

	public static PKMacValue GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return null;
	}

	private PKMacValue(Asn1Sequence seq)
	{
	}

	public PKMacValue(PbmParameter pbmParams, DerBitString macValue)
	{
	}

	public PKMacValue(AlgorithmIdentifier algID, DerBitString macValue)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
