using System.IO;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsPublicKeyParameters : LmsKeyParameters, ILmsContextBasedVerifier
{
	private LMSigParameters parameterSet;

	private LMOtsParameters lmOtsType;

	private byte[] I;

	private byte[] T1;

	public LmsPublicKeyParameters(LMSigParameters parameterSet, LMOtsParameters lmOtsType, byte[] T1, byte[] I)
		: base(isPrivateKey: false)
	{
	}

	public static LmsPublicKeyParameters GetInstance(object src)
	{
		return null;
	}

	internal static LmsPublicKeyParameters Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public LMSigParameters GetSigParameters()
	{
		return null;
	}

	public LMOtsParameters GetOtsParameters()
	{
		return null;
	}

	public LmsParameters GetLmsParameters()
	{
		return null;
	}

	public byte[] GetT1()
	{
		return null;
	}

	internal bool MatchesT1(byte[] sig)
	{
		return false;
	}

	public byte[] GetI()
	{
		return null;
	}

	internal byte[] RefI()
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

	internal byte[] ToByteArray()
	{
		return null;
	}

	public LmsContext GenerateLmsContext(byte[] signature)
	{
		return null;
	}

	internal LmsContext GenerateOtsContext(LmsSignature S)
	{
		return null;
	}

	public bool Verify(LmsContext context)
	{
		return false;
	}
}
