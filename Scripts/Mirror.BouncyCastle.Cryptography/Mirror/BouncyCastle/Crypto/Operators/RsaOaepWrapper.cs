using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crypto.Operators;

internal class RsaOaepWrapper : IKeyWrapper, IKeyUnwrapper
{
	private readonly AlgorithmIdentifier algId;

	private readonly IAsymmetricBlockCipher engine;

	public object AlgorithmDetails => null;

	public RsaOaepWrapper(bool forWrapping, ICipherParameters parameters, DerObjectIdentifier digestOid)
	{
	}

	public RsaOaepWrapper(bool forWrapping, ICipherParameters parameters, DerObjectIdentifier digestOid, DerObjectIdentifier mgfOid)
	{
	}

	public IBlockResult Unwrap(byte[] cipherText, int offset, int length)
	{
		return null;
	}

	public IBlockResult Wrap(byte[] keyData)
	{
		return null;
	}
}
