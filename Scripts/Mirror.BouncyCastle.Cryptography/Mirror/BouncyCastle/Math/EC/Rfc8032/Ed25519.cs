using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

public static class Ed25519
{
	public enum Algorithm
	{
		Ed25519 = 0,
		Ed25519ctx = 1,
		Ed25519ph = 2
	}

	public sealed class PublicPoint
	{
		internal readonly int[] m_data;

		internal PublicPoint(int[] data)
		{
		}
	}

	private struct PointAccum
	{
		internal int[] x;

		internal int[] y;

		internal int[] z;

		internal int[] u;

		internal int[] v;
	}

	private struct PointAffine
	{
		internal int[] x;

		internal int[] y;
	}

	private struct PointExtended
	{
		internal int[] x;

		internal int[] y;

		internal int[] z;

		internal int[] t;
	}

	private struct PointPrecomp
	{
		internal int[] ymx_h;

		internal int[] ypx_h;

		internal int[] xyd;
	}

	private struct PointPrecompZ
	{
		internal int[] ymx_h;

		internal int[] ypx_h;

		internal int[] xyd;

		internal int[] z;
	}

	private struct PointTemp
	{
		internal int[] r0;

		internal int[] r1;
	}

	private const int CoordUints = 8;

	private const int PointBytes = 32;

	private const int ScalarUints = 8;

	private const int ScalarBytes = 32;

	public static readonly int PrehashSize;

	public static readonly int PublicKeySize;

	public static readonly int SecretKeySize;

	public static readonly int SignatureSize;

	private static readonly byte[] Dom2Prefix;

	private static readonly uint[] P;

	private static readonly uint[] Order8_y1;

	private static readonly uint[] Order8_y2;

	private static readonly int[] B_x;

	private static readonly int[] B_y;

	private static readonly int[] B128_x;

	private static readonly int[] B128_y;

	private static readonly int[] C_d;

	private static readonly int[] C_d2;

	private static readonly int[] C_d4;

	private const int WnafWidth128 = 4;

	private const int WnafWidthBase = 6;

	private const int PrecompBlocks = 8;

	private const int PrecompTeeth = 4;

	private const int PrecompSpacing = 8;

	private const int PrecompRange = 256;

	private const int PrecompPoints = 8;

	private const int PrecompMask = 7;

	private static readonly object PrecompLock;

	private static PointPrecomp[] PrecompBaseWnaf;

	private static PointPrecomp[] PrecompBase128Wnaf;

	private static int[] PrecompBaseComb;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		return null;
	}

	private static bool CheckContextVar(byte[] ctx, byte phflag)
	{
		return false;
	}

	private static int CheckPoint(ref PointAffine p)
	{
		return 0;
	}

	private static int CheckPoint(PointAccum p)
	{
		return 0;
	}

	private static bool CheckPointFullVar(byte[] p)
	{
		return false;
	}

	private static bool CheckPointOrderVar(ref PointAffine p)
	{
		return false;
	}

	private static bool CheckPointVar(byte[] p)
	{
		return false;
	}

	private static byte[] Copy(byte[] buf, int off, int len)
	{
		return null;
	}

	private static IDigest CreateDigest()
	{
		return null;
	}

	public static IDigest CreatePrehash()
	{
		return null;
	}

	private static bool DecodePointVar(byte[] p, bool negate, ref PointAffine r)
	{
		return false;
	}

	private static void Dom2(IDigest d, byte phflag, byte[] ctx)
	{
	}

	private static void EncodePoint(ref PointAffine p, byte[] r, int rOff)
	{
	}

	public static void EncodePublicPoint(PublicPoint publicPoint, byte[] pk, int pkOff)
	{
	}

	private static int EncodeResult(ref PointAccum p, byte[] r, int rOff)
	{
		return 0;
	}

	private static PublicPoint ExportPoint(ref PointAffine p)
	{
		return null;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
	}

	public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
	{
	}

	public static PublicPoint GeneratePublicKey(byte[] sk, int skOff)
	{
		return null;
	}

	private static uint GetWindow4(uint[] x, int n)
	{
		return 0u;
	}

	private static void GroupCombBits(uint[] n)
	{
	}

	private static void ImplSign(IDigest d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	private static bool ImplVerify(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	private static void Init(out PointAccum r)
	{
		r = default;
	}

	private static void Init(out PointAffine r)
	{
		r = default;
	}

	private static void Init(out PointExtended r)
	{
		r = default;
	}

	private static void Init(out PointPrecomp r)
	{
		r = default;
	}

	private static void Init(out PointPrecompZ r)
	{
		r = default;
	}

	private static void Init(out PointTemp r)
	{
		r = default;
	}

	private static void InvertDoubleZs(PointExtended[] points)
	{
	}

	private static void NormalizeToAffine(ref PointAccum p, ref PointAffine r)
	{
	}

	private static bool NormalizeToNeutralElementVar(ref PointAccum p)
	{
		return false;
	}

	private static void PointAdd(ref PointExtended p, ref PointExtended q, ref PointExtended r, ref PointTemp t)
	{
	}

	private static void PointAdd(ref PointPrecomp p, ref PointAccum r, ref PointTemp t)
	{
	}

	private static void PointAdd(ref PointPrecompZ p, ref PointAccum r, ref PointTemp t)
	{
	}

	private static void PointAddVar(bool negate, ref PointPrecomp p, ref PointAccum r, ref PointTemp t)
	{
	}

	private static void PointAddVar(bool negate, ref PointPrecompZ p, ref PointAccum r, ref PointTemp t)
	{
	}

	private static void PointCopy(ref PointAccum p, ref PointExtended r)
	{
	}

	private static void PointCopy(ref PointAffine p, ref PointExtended r)
	{
	}

	private static void PointCopy(ref PointExtended p, ref PointPrecompZ r)
	{
	}

	private static void PointDouble(ref PointAccum r)
	{
	}

	private static void PointLookup(int block, int index, ref PointPrecomp p)
	{
	}

	private static void PointLookupZ(uint[] x, int n, int[] table, ref PointPrecompZ r)
	{
	}

	private static void PointPrecompute(ref PointAffine p, PointExtended[] points, int pointsOff, int pointsLen, ref PointTemp t)
	{
	}

	private static int[] PointPrecomputeZ(ref PointAffine p, int count, ref PointTemp t)
	{
		return null;
	}

	private static void PointPrecomputeZ(ref PointAffine p, PointPrecompZ[] points, int count, ref PointTemp t)
	{
	}

	private static void PointSetNeutral(ref PointAccum p)
	{
	}

	public static void Precompute()
	{
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
	}

	private static void ScalarMult(byte[] k, ref PointAffine p, ref PointAccum r)
	{
	}

	private static void ScalarMultBase(byte[] k, ref PointAccum r)
	{
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
	}

	internal static void ScalarMultBaseYZ(byte[] k, int kOff, int[] y, int[] z)
	{
	}

	private static void ScalarMultOrderVar(ref PointAffine p, ref PointAccum r)
	{
	}

	private static void ScalarMultStraus128Var(uint[] nb, uint[] np, ref PointAffine p, uint[] nq, ref PointAffine q, ref PointAccum r)
	{
	}

	public static void Sign(byte[] sk, int skOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
	}

	public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
	{
		return false;
	}

	public static PublicPoint ValidatePublicKeyFullExport(byte[] pk, int pkOff)
	{
		return null;
	}

	public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
	{
		return false;
	}

	public static PublicPoint ValidatePublicKeyPartialExport(byte[] pk, int pkOff)
	{
		return null;
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	public static bool Verify(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	public static bool Verify(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] ctx, byte[] m, int mOff, int mLen)
	{
		return false;
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff)
	{
		return false;
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] ctx, byte[] ph, int phOff)
	{
		return false;
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph)
	{
		return false;
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] ctx, IDigest ph)
	{
		return false;
	}
}
