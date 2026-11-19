namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public static class Lms
{
	internal static ushort D_LEAF;

	internal static ushort D_INTR;

	public static LmsPrivateKeyParameters GenerateKeys(LMSigParameters parameterSet, LMOtsParameters lmOtsParameters, int q, byte[] I, byte[] rootSeed)
	{
		return null;
	}

	public static LmsSignature GenerateSign(LmsPrivateKeyParameters privateKey, byte[] message)
	{
		return null;
	}

	public static LmsSignature GenerateSign(LmsContext context)
	{
		return null;
	}

	public static bool VerifySignature(LmsPublicKeyParameters publicKey, LmsSignature S, byte[] message)
	{
		return false;
	}

	public static bool VerifySignature(LmsPublicKeyParameters publicKey, byte[] S, byte[] message)
	{
		return false;
	}

	public static bool VerifySignature(LmsPublicKeyParameters publicKey, LmsContext context)
	{
		return false;
	}
}
