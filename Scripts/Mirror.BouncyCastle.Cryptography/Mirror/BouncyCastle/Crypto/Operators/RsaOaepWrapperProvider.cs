using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Operators;

internal class RsaOaepWrapperProvider : WrapperProvider
{
	private readonly DerObjectIdentifier digestOid;

	private readonly DerObjectIdentifier mgfOid;

	internal RsaOaepWrapperProvider(DerObjectIdentifier digestOid)
	{
	}

	internal RsaOaepWrapperProvider(DerObjectIdentifier digestOid, DerObjectIdentifier mgfOid)
	{
	}

	object WrapperProvider.CreateWrapper(bool forWrapping, ICipherParameters parameters)
	{
		return null;
	}
}
