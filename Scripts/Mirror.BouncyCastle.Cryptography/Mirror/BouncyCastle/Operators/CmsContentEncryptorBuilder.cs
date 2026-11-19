using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Operators;

public class CmsContentEncryptorBuilder
{
	private static readonly IDictionary<DerObjectIdentifier, int> KeySizes;

	private readonly DerObjectIdentifier encryptionOID;

	private readonly int keySize;

	static CmsContentEncryptorBuilder()
	{
	}

	private static int GetKeySize(DerObjectIdentifier oid)
	{
		return 0;
	}

	public CmsContentEncryptorBuilder(DerObjectIdentifier encryptionOID)
	{
	}

	public CmsContentEncryptorBuilder(DerObjectIdentifier encryptionOID, int keySize)
	{
	}

	public ICipherBuilderWithKey Build()
	{
		return null;
	}
}
