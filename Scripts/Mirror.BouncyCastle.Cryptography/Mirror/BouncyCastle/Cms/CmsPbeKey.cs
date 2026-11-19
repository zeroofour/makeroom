using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

public abstract class CmsPbeKey : ICipherParameters
{
	internal readonly char[] password;

	internal readonly byte[] salt;

	internal readonly int iterationCount;

	public byte[] Salt => null;

	public int IterationCount => 0;

	public string Algorithm => null;

	public string Format => null;

	public CmsPbeKey(char[] password, byte[] salt, int iterationCount)
	{
	}

	public CmsPbeKey(char[] password, AlgorithmIdentifier keyDerivationAlgorithm)
	{
	}

	~CmsPbeKey()
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	internal abstract KeyParameter GetEncoded(string algorithmOid);
}
