using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class X931Signer : ISigner
{
	private IDigest digest;

	private IAsymmetricBlockCipher cipher;

	private RsaKeyParameters kParam;

	private int trailer;

	private int keyBits;

	private byte[] block;

	public virtual string AlgorithmName => null;

	public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest)
	{
	}

	public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
	{
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
	}

	public virtual void Update(byte b)
	{
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int inLen)
	{
	}

	public virtual int GetMaxSignatureSize()
	{
		return 0;
	}

	public virtual byte[] GenerateSignature()
	{
		return null;
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		return false;
	}

	public virtual void Reset()
	{
	}

	private void CreateSignatureBlock()
	{
	}
}
