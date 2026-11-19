using System;
using System.IO;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class HssPublicKeyParameters : LmsKeyParameters, ILmsContextBasedVerifier
{
	private readonly int m_level;

	private readonly LmsPublicKeyParameters m_lmsPublicKey;

	[Obsolete("Use 'Level' instead")]
	public int L => 0;

	public int Level => 0;

	public LmsPublicKeyParameters LmsPublicKey => null;

	public HssPublicKeyParameters(int l, LmsPublicKeyParameters lmsPublicKey)
		: base(isPrivateKey: false)
	{
	}

	public static HssPublicKeyParameters GetInstance(object src)
	{
		return null;
	}

	internal static HssPublicKeyParameters Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public LmsContext GenerateLmsContext(byte[] sigEnc)
	{
		return null;
	}

	public bool Verify(LmsContext context)
	{
		return false;
	}
}
