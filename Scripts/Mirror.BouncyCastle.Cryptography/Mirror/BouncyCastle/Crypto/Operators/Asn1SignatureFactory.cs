using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1SignatureFactory : ISignatureFactory
{
	private readonly AlgorithmIdentifier algID;

	private readonly string algorithm;

	private readonly AsymmetricKeyParameter privateKey;

	private readonly SecureRandom random;

	public object AlgorithmDetails => null;

	public static IEnumerable<string> SignatureAlgNames => null;

	public Asn1SignatureFactory(string algorithm, AsymmetricKeyParameter privateKey)
	{
	}

	public Asn1SignatureFactory(string algorithm, AsymmetricKeyParameter privateKey, SecureRandom random)
	{
	}

	public IStreamCalculator<IBlockResult> CreateCalculator()
	{
		return null;
	}
}
