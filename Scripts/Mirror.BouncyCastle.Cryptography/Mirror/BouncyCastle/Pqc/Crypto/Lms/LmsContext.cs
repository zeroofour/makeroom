using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsContext : IDigest
{
	private readonly byte[] m_c;

	private readonly LMOtsPrivateKey m_privateKey;

	private readonly LMSigParameters m_sigParams;

	private readonly byte[][] m_path;

	private readonly LMOtsPublicKey m_publicKey;

	private readonly object m_signature;

	private LmsSignedPubKey[] m_signedPubKeys;

	private IDigest m_digest;

	public byte[] C => null;

	internal byte[][] Path => null;

	internal LMOtsPrivateKey PrivateKey => null;

	public LMOtsPublicKey PublicKey => null;

	internal LMSigParameters SigParams => null;

	public object Signature => null;

	internal LmsSignedPubKey[] SignedPubKeys => null;

	public string AlgorithmName => null;

	public LmsContext(LMOtsPrivateKey privateKey, LMSigParameters sigParams, IDigest digest, byte[] C, byte[][] path)
	{
	}

	public LmsContext(LMOtsPublicKey publicKey, object signature, IDigest digest)
	{
	}

	public byte[] GetQ()
	{
		return null;
	}

	internal LmsContext WithSignedPublicKeys(LmsSignedPubKey[] signedPubKeys)
	{
		return null;
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public int GetByteLength()
	{
		return 0;
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}
}
