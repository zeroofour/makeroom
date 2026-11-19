using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pkcs;

public class Pkcs8EncryptedPrivateKeyInfoBuilder
{
	private PrivateKeyInfo privateKeyInfo;

	public Pkcs8EncryptedPrivateKeyInfoBuilder(byte[] privateKeyInfo)
	{
	}

	public Pkcs8EncryptedPrivateKeyInfoBuilder(PrivateKeyInfo privateKeyInfo)
	{
	}

	public Pkcs8EncryptedPrivateKeyInfo Build(ICipherBuilder encryptor)
	{
		return null;
	}
}
