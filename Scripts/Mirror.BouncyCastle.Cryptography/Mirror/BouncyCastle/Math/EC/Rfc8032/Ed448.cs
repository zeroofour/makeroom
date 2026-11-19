using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

public static class Ed448
{
	public enum Algorithm
	{
		Ed448 = 0,
		Ed448ph = 1
	}

	public sealed class PublicPoint
	{
		internal readonly uint[] m_data;

		internal PublicPoint(uint[] data)
		{
		}
	}

	private struct PointAffine
	{
		internal uint[] x;

		internal uint[] y;
	}

	private struct PointProjective
	{
		internal uint[] x;

		internal uint[] y;

		internal uint[] z;
	}

	private struct PointTemp
	{
		internal uint[] r0;

		internal uint[] r1;

		internal uint[] r2;

		internal uint[] r3;

		internal uint[] r4;

		internal uint[] r5;

		internal uint[] r6;

		internal uint[] r7;
	}

	private const int CoordUints = 14;

	private const int PointBytes = 57;

	private const int ScalarUints = 14;

	private const int ScalarBytes = 57;

	public static readonly int PrehashSize;

	public static readonly int PublicKeySize;

	public static readonly int SecretKeySize;

	public static readonly int SignatureSize;

	private static readonly byte[] Dom4Prefix;

	private static readonly uint[] P;

	private static readonly uint[] B_x;

	private static readonly uint[] B_y;

	private static readonly uint[] B225_x;

	private static readonly uint[] B225_y;

	private const uint C_d = 39081u;

	private const int WnafWidth225 = 5;

	private const int WnafWidthBase = 7;

	private const int PrecompBlocks = 5;

	private const int PrecompTeeth = 5;

	private const int PrecompSpacing = 18;

	private const int PrecompRange = 450;

	private const int PrecompPoints = 16;

	private const int PrecompMask = 15;

	private static readonly object PrecompLock;

	private static PointAffine[] PrecompBaseWnaf;

	private static PointAffine[] PrecompBase225Wnaf;

	private static uint[] PrecompBaseComb;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		return null;
	}

	private static bool CheckContextVar(byte[] ctx)
	{
		return false;
	}

	private static int CheckPoint(ref PointAffine p)
	{
		return 0;
	}

	private static int CheckPoint(PointProjective p)
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

	public static IXof CreatePrehash()
	{
		return null;
	}

	private static IXof CreateXof()
	{
		return null;
	}

	private static bool DecodePointVar(byte[] p, bool negate, ref PointAffine r)
	{
		return false;
	}

	private static void Dom4(IXof d, byte phflag, byte[] ctx)
	{
	}

	private static void EncodePoint(ref PointAffine p, byte[] r, int rOff)
	{
	}

	public static void EncodePublicPoint(PublicPoint publicPoint, byte[] pk, int pkOff)
	{
	}

	private static int EncodeResult(ref PointProjective p, byte[] r, int rOff)
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

	private static void ImplSign(IXof d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
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

	private static void Init(out PointAffine r)
	{
		r = default;
	}

	private static void Init(out PointProjective r)
	{
		r = default;
	}

	private static void Init(out PointTemp r)
	{
		r = default;
	}

	private static void InvertZs(PointProjective[] points)
	{
	}

	private static void NormalizeToAffine(ref PointProjective p, ref PointAffine r)
	{
	}

	private static bool NormalizeToNeutralElementVar(ref PointProjective p)
	{
		return false;
	}

	private static void PointAdd(ref PointAffine p, ref PointProjective r, ref PointTemp t)
	{
	}

	private static void PointAdd(ref PointProjective p, ref PointProjective r, ref PointTemp t)
	{
	}

	private static void PointAddVar(bool negate, ref PointAffine p, ref PointProjective r, ref PointTemp t)
	{
	}

	private static void PointAddVar(bool negate, ref PointProjective p, ref PointProjective r, ref PointTemp t)
	{
	}

	private static void PointCopy(ref PointAffine p, ref PointProjective r)
	{
	}

	private static void PointCopy(ref PointProjective p, ref PointProjective r)
	{
	}

	private static void PointDouble(ref PointProjective r, ref PointTemp t)
	{
	}

	private static void PointLookup(int block, int index, ref PointAffine p)
	{
	}

	private static void PointLookup(uint[] x, int n, uint[] table, ref PointProjective r)
	{
	}

	private static void PointLookup15(uint[] table, ref PointProjective r)
	{
	}

	private static uint[] PointPrecompute(ref PointProjective p, int count, ref PointTemp t)
	{
		return null;
	}

	private static void PointPrecompute(ref PointAffine p, PointProjective[] points, int pointsOff, int pointsLen, ref PointTemp t)
	{
	}

	private static void PointSetNeutral(ref PointProjective p)
	{
	}

	public static void Precompute()
	{
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
	}

	private static void ScalarMult(byte[] k, ref PointProjective p, ref PointProjective r)
	{
	}

	private static void ScalarMultBase(byte[] k, ref PointProjective r)
	{
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
	}

	internal static void ScalarMultBaseXY(byte[] k, int kOff, uint[] x, uint[] y)
	{
	}

	private static void ScalarMultOrderVar(ref PointAffine p, ref PointProjective r)
	{
	}

	private static void ScalarMultStraus225Var(uint[] nb, uint[] np, ref PointAffine p, uint[] nq, ref PointAffine q, ref PointProjective r)
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

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, IXof ph, byte[] sig, int sigOff)
	{
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, IXof ph, byte[] sig, int sigOff)
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

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, IXof ph)
	{
		return false;
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, PublicPoint publicPoint, byte[] ctx, IXof ph)
	{
		return false;
	}
}
