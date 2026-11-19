using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

public class Pkcs5Scheme2PbeKey : CmsPbeKey
{
	public Pkcs5Scheme2PbeKey(char[] password, byte[] salt, int iterationCount)
		: base(null, null, 0)
	{
	}

	public Pkcs5Scheme2PbeKey(char[] password, AlgorithmIdentifier keyDerivationAlgorithm)
		: base(null, null, 0)
	{
	}

	internal override KeyParameter GetEncoded(string algorithmOid)
	{
		return null;
	}
}
