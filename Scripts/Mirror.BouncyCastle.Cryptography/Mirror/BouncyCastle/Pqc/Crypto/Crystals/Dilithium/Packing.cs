namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

internal class Packing
{
	public static byte[] PackPublicKey(PolyVecK t1, DilithiumEngine Engine)
	{
		return null;
	}

	public static PolyVecK UnpackPublicKey(PolyVecK t1, byte[] pk, DilithiumEngine Engine)
	{
		return null;
	}

	public static void PackSecretKey(byte[] t0_, byte[] s1_, byte[] s2_, PolyVecK t0, PolyVecL s1, PolyVecK s2, DilithiumEngine Engine)
	{
	}

	public static void UnpackSecretKey(PolyVecK t0, PolyVecL s1, PolyVecK s2, byte[] t0Enc, byte[] s1Enc, byte[] s2Enc, DilithiumEngine Engine)
	{
	}

	public static void PackSignature(byte[] sig, byte[] c, PolyVecL z, PolyVecK h, DilithiumEngine engine)
	{
	}

	public static bool UnpackSignature(PolyVecL z, PolyVecK h, byte[] sig, DilithiumEngine engine)
	{
		return false;
	}
}
