using Mirror.BouncyCastle.Crypto.Macs;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class HMacDsaKCalculator : IDsaKCalculator
{
	private readonly HMac hMac;

	private readonly byte[] K;

	private readonly byte[] V;

	private BigInteger n;

	public virtual bool IsDeterministic => false;

	public HMacDsaKCalculator(IDigest digest)
	{
	}

	public virtual void Init(BigInteger n, SecureRandom random)
	{
	}

	public void Init(BigInteger n, BigInteger d, byte[] message)
	{
	}

	public virtual BigInteger NextK()
	{
		return null;
	}

	protected virtual void InitAdditionalInput0(HMac hmac0)
	{
	}

	protected virtual void InitAdditionalInput1(HMac hmac1)
	{
	}

	private BigInteger BitsToInt(byte[] t)
	{
		return null;
	}
}
