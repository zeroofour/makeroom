using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crypto.Operators;

internal class RsaPkcs1Wrapper : IKeyWrapper, IKeyUnwrapper
{
	private readonly AlgorithmIdentifier algId;

	private readonly IAsymmetricBlockCipher engine;

	public object AlgorithmDetails => null;

	public RsaPkcs1Wrapper(bool forWrapping, ICipherParameters parameters)
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
