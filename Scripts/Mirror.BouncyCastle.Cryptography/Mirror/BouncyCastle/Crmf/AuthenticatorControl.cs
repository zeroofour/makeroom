using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crmf;

public class AuthenticatorControl : IControl
{
	private readonly DerUtf8String m_token;

	public DerObjectIdentifier Type => null;

	public Asn1Encodable Value => null;

	public AuthenticatorControl(DerUtf8String token)
	{
	}

	public AuthenticatorControl(string token)
	{
	}
}
