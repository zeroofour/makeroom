using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1CipherBuilderWithKey : ICipherBuilderWithKey, ICipherBuilder
{
	private readonly KeyParameter encKey;

	private AlgorithmIdentifier algorithmIdentifier;

	public object AlgorithmDetails => null;

	public ICipherParameters Key => null;

	public Asn1CipherBuilderWithKey(DerObjectIdentifier encryptionOID, int keySize, SecureRandom random)
	{
	}

	public int GetMaxOutputSize(int inputLen)
	{
		return 0;
	}

	public ICipher BuildCipher(Stream stream)
	{
		return null;
	}
}
