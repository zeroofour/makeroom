using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;
using Mirror.BouncyCastle.Math.EC.Multiplier;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class SM2Signer : ISigner
{
	private enum State
	{
		Uninitialized = 0,
		Init = 1,
		Data = 2
	}

	private readonly IDsaKCalculator kCalculator;

	private readonly IDigest digest;

	private readonly IDsaEncoding encoding;

	private State m_state;

	private ECDomainParameters ecParams;

	private ECPoint pubPoint;

	private ECKeyParameters ecKey;

	private byte[] z;

	public virtual string AlgorithmName => null;

	public SM2Signer()
	{
	}

	public SM2Signer(IDigest digest)
	{
	}

	public SM2Signer(IDsaEncoding encoding)
	{
	}

	public SM2Signer(IDsaEncoding encoding, IDigest digest)
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

	private bool VerifySignature(BigInteger r, BigInteger s)
	{
		return false;
	}

	private void CheckData()
	{
	}

	private byte[] GetZ(byte[] userID)
	{
		return null;
	}

	private void AddUserID(IDigest digest, byte[] userID)
	{
	}

	private void AddFieldElement(IDigest digest, ECFieldElement v)
	{
	}

	protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
	{
		return null;
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return null;
	}
}
