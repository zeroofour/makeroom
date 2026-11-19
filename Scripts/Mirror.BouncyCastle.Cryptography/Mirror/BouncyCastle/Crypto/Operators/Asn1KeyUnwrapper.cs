using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1KeyUnwrapper : IKeyUnwrapper
{
	private string algorithm;

	private IKeyUnwrapper wrapper;

	public object AlgorithmDetails => null;

	public Asn1KeyUnwrapper(string algorithm, ICipherParameters key)
	{
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, ICipherParameters key)
	{
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, ICipherParameters key)
	{
	}

	public IBlockResult Unwrap(byte[] keyData, int offSet, int length)
	{
		return null;
	}
}
