using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;
using Mirror.BouncyCastle.Math.EC.Multiplier;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class SM2Engine
{
	public enum Mode
	{
		C1C2C3 = 0,
		C1C3C2 = 1
	}

	private readonly IDigest mDigest;

	private readonly Mode mMode;

	private bool mForEncryption;

	private ECKeyParameters mECKey;

	private ECDomainParameters mECParams;

	private int mCurveLength;

	private SecureRandom mRandom;

	public SM2Engine()
	{
	}

	public SM2Engine(Mode mode)
	{
	}

	public SM2Engine(IDigest digest)
	{
	}

	public SM2Engine(IDigest digest, Mode mode)
	{
	}

	public virtual void Init(bool forEncryption, ICipherParameters param)
	{
	}

	public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
	{
		return null;
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return null;
	}

	private byte[] Encrypt(byte[] input, int inOff, int inLen)
	{
		return null;
	}

	private byte[] Decrypt(byte[] input, int inOff, int inLen)
	{
		return null;
	}

	private bool NotEncrypted(byte[] encData, byte[] input, int inOff)
	{
		return false;
	}

	private void Kdf(IDigest digest, ECPoint c1, byte[] encData)
	{
	}

	private BigInteger NextK()
	{
		return null;
	}

	private void AddFieldElement(IDigest digest, ECFieldElement v)
	{
	}
}
