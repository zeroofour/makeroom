namespace Mirror.BouncyCastle.Crypto.Signers;

public class Iso9796d2Signer : ISignerWithRecovery, ISigner
{
	private IDigest digest;

	private IAsymmetricBlockCipher cipher;

	private int trailer;

	private int keyBits;

	private byte[] block;

	private byte[] mBuf;

	private int messageLength;

	private bool fullMessage;

	private byte[] recoveredMessage;

	private byte[] preSig;

	private byte[] preBlock;

	public virtual string AlgorithmName => null;

	public byte[] GetRecoveredMessage()
	{
		return null;
	}

	public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
	{
	}

	public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest)
	{
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
	}

	private bool IsSameAs(byte[] a, byte[] b)
	{
		return false;
	}

	private void ClearBlock(byte[] block)
	{
	}

	public virtual void UpdateWithRecoveredMessage(byte[] signature)
	{
	}

	public virtual void Update(byte input)
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

	private bool ReturnFalse(byte[] block)
	{
		return false;
	}

	public virtual bool HasFullMessage()
	{
		return false;
	}
}
