using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Crmf;

public class EncryptedValueBuilder
{
	private readonly IKeyWrapper wrapper;

	private readonly ICipherBuilderWithKey encryptor;

	private readonly IEncryptedValuePadder padder;

	public EncryptedValueBuilder(IKeyWrapper wrapper, ICipherBuilderWithKey encryptor)
	{
	}

	public EncryptedValueBuilder(IKeyWrapper wrapper, ICipherBuilderWithKey encryptor, IEncryptedValuePadder padder)
	{
	}

	public EncryptedValue Build(char[] revocationPassphrase)
	{
		return null;
	}

	public EncryptedValue Build(X509Certificate holder)
	{
		return null;
	}

	public EncryptedValue Build(PrivateKeyInfo privateKeyInfo)
	{
		return null;
	}

	private EncryptedValue EncryptData(byte[] data)
	{
		return null;
	}

	private byte[] PadData(byte[] data)
	{
		return null;
	}
}
