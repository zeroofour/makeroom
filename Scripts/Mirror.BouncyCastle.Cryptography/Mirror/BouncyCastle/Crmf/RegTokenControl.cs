using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crmf;

public class RegTokenControl : IControl
{
	private readonly DerUtf8String m_token;

	public DerObjectIdentifier Type => null;

	public Asn1Encodable Value => null;

	public RegTokenControl(DerUtf8String token)
	{
	}

	public RegTokenControl(string token)
	{
	}
}
