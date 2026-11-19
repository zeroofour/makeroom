using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crmf;

internal class PKMacValueVerifier
{
	private readonly PKMacBuilder m_builder;

	internal PKMacValueVerifier(PKMacBuilder builder)
	{
	}

	internal virtual bool IsValid(PKMacValue value, char[] password, SubjectPublicKeyInfo keyInfo)
	{
		return false;
	}
}
