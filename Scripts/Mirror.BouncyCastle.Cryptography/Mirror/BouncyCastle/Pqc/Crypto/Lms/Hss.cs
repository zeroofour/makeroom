namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public static class Hss
{
	public static HssPrivateKeyParameters GenerateHssKeyPair(HssKeyGenerationParameters parameters)
	{
		return null;
	}

	public static void IncrementIndex(HssPrivateKeyParameters keyPair)
	{
	}

	public static void RangeTestKeys(HssPrivateKeyParameters keyPair)
	{
	}

	public static HssSignature GenerateSignature(HssPrivateKeyParameters keyPair, byte[] message)
	{
		return null;
	}

	public static HssSignature GenerateSignature(int L, LmsContext context)
	{
		return null;
	}

	public static bool VerifySignature(HssPublicKeyParameters publicKey, HssSignature signature, byte[] message)
	{
		return false;
	}
}
