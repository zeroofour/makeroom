using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1KeyWrapper : IKeyWrapper
{
	private string algorithm;

	private IKeyWrapper wrapper;

	public object AlgorithmDetails => null;

	public Asn1KeyWrapper(string algorithm, X509Certificate cert)
	{
	}

	public Asn1KeyWrapper(string algorithm, ICipherParameters key)
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, X509Certificate cert)
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, ICipherParameters key)
	{
	}

	public Asn1KeyWrapper(AlgorithmIdentifier algorithm, X509Certificate cert)
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, X509Certificate cert)
	{
	}

	public Asn1KeyWrapper(AlgorithmIdentifier algorithm, ICipherParameters key)
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, ICipherParameters key)
	{
	}

	public IBlockResult Wrap(byte[] keyData)
	{
		return null;
	}
}
