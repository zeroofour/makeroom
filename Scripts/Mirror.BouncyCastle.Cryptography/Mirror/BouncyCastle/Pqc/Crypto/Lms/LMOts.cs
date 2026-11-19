namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public static class LMOts
{
	private static ushort D_PBLC;

	private static int ITER_K;

	private static int ITER_PREV;

	private static int ITER_J;

	internal static int SEED_RANDOMISER_INDEX;

	internal static int MAX_HASH;

	internal static ushort D_MESG;

	public static int Coef(byte[] S, int i, int w)
	{
		return 0;
	}

	public static int Cksm(byte[] S, int sLen, LMOtsParameters parameters)
	{
		return 0;
	}

	public static LMOtsPublicKey LmsOtsGeneratePublicKey(LMOtsPrivateKey privateKey)
	{
		return null;
	}

	internal static byte[] LmsOtsGeneratePublicKey(LMOtsParameters parameters, byte[] I, int q, byte[] masterSecret)
	{
		return null;
	}

	public static LMOtsSignature lm_ots_generate_signature(LMSigParameters sigParams, LMOtsPrivateKey privateKey, byte[][] path, byte[] message, bool preHashed)
	{
		return null;
	}

	public static LMOtsSignature LMOtsGenerateSignature(LMOtsPrivateKey privateKey, byte[] Q, byte[] C)
	{
		return null;
	}

	public static bool LMOtsValidateSignature(LMOtsPublicKey publicKey, LMOtsSignature signature, byte[] message, bool prehashed)
	{
		return false;
	}

	public static byte[] LMOtsValidateSignatureCalculate(LMOtsPublicKey publicKey, LMOtsSignature signature, byte[] message)
	{
		return null;
	}

	public static byte[] LMOtsValidateSignatureCalculate(LmsContext context)
	{
		return null;
	}
}
